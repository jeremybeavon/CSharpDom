﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class ChildNodeList<TParent, TParentSyntax, TChild, TChildSyntax> : IList<TChild>, INode
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly IChildSyntaxList<TParentSyntax, TChildSyntax> list;
        private readonly Func<int, TChild> factory;
        private readonly IList<TChild> innerList;
        private bool isInitialized;
        private bool isRefreshList;

        public ChildNodeList(
            Node<TParent, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChild> factory)
            : this(node, list)
        {
            this.factory = index => factory();
        }

        public ChildNodeList(
            Node<TParent, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChildSyntax, TChild> factory)
            : this(node, list)
        {
            this.factory = index => factory(this.list[index]);
        }

        private ChildNodeList(
            Node<TParent, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list)
        {
            node.ChildNodes.Add(this);
            this.node = node;
            this.list = list;
            innerList = new List<TChild>();
        }

        public bool IsLocked { get; set; }

        public int Count
        {
            get
            {
                LogDebugMessage("Count");
                RefreshList();
                return innerList.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public IList<INode> ChildNodes { get; } = new List<INode>();

        public TChild this[int index]
        {
            get
            {
                if (CodeAnalysisLogger.LogDebugMessages)
                {
                    LogDebugMessage($"this[{index}]");
                }

                RefreshList();
                return innerList[index];
            }
            set
            {
                if (CodeAnalysisLogger.LogDebugMessages)
                {
                    LogDebugMessage($"this[{index}] = {value?.GetHashCode()}");
                }

                RefreshList();
                isRefreshList = true;
                list[index] = value.Node.Syntax;
                InternalSet(index, value);
                isRefreshList = false;
            }
        }
        
        public int IndexOf(TChild item)
        {
            LogDebugMessage("IndexOf");
            RefreshList();
            return innerList.IndexOf(item);
        }

        public void Insert(int index, TChild item)
        {
            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"Insert: index={index}, item={item?.GetHashCode()}");
            }

            RefreshList();
            isRefreshList = true;
            TChildSyntax syntax = item.Node.Syntax;
            list.Insert(index, syntax);
            InternalInsert(index, item);
            isRefreshList = false;
        }

        public void RemoveAt(int index)
        {
            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"RemoveAt: index={index}");
            }

            RefreshList();
            isRefreshList = true;
            InternalRemoveAt(index);
            list.RemoveAt(index);
            isRefreshList = false;
        }

        public void Add(TChild item)
        {
            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"Insert: item={item?.GetHashCode()}");
            }

            RefreshList();
            isRefreshList = true;
            list.Add(item.Node.Syntax);
            InternalAdd(item);
            isRefreshList = false;
        }

        public void Clear()
        {
            LogDebugMessage("Clear");
            RefreshList();
            isRefreshList = true;
            while (list.Count != 0)
            {
                list.RemoveAt(0);
                innerList[0].Node.RemoveParentNode();
            }

            innerList.Clear();
            isRefreshList = false;
        }

        public bool Contains(TChild item)
        {
            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"Contains: item={item?.GetHashCode()}");
            }

            RefreshList();
            return innerList.Contains(item);
        }

        public void CopyTo(TChild[] array, int arrayIndex)
        {
            LogDebugMessage("CopyTo");
            RefreshList();
            innerList.CopyTo(array, arrayIndex);
        }

        public bool Remove(TChild item)
        {
            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"Remove: item={item?.GetHashCode()}");
            }

            RefreshList();
            isRefreshList = true;
            TChildSyntax syntax = item.Node.Syntax;
            bool isRemoved = InternalRemove(item);
            list.Remove(syntax);
            isRefreshList = false;
            return isRemoved;
        }

        public IEnumerator<TChild> GetEnumerator()
        {
            LogDebugMessage("GetEnumerator");
            RefreshList();
            return innerList.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        void INode.RefreshSyntax()
        {
            RefreshList();
        }

        private TChildSyntax GetChildSyntax(int index)
        {
            RefreshList();
            return list[index];
        }

        private void SetParent(TChild item, int initialIndex)
        {
            item.Node.SetParent(node.Value, initialIndex, GetChildSyntax, list.Set);
            ChildNodes.Add(item.Node);
        }
        
        private void InternalAdd(TChild item)
        {
            innerList.Add(item);
            SetParent(item, innerList.Count - 1);
        }

        private void InternalInsert(int index, TChild item)
        {
            if (index == innerList.Count)
            {
                InternalAdd(item);
                return;
            }

            innerList.Insert(index, item);
            for (int childIndex = index; childIndex < innerList.Count; childIndex++)
            {
                innerList[childIndex].Node.Index++;
            }

            SetParent(item, index);
        }

        private void InternalClear()
        {
            innerList.Clear();
        }

        private bool InternalRemove(TChild item)
        {
            int index = IndexOf(item);
            if (index < 0)
            {
                return false;
            }

            InternalRemoveAt(index);
            return true;
        }

        private void InternalRemoveAt(int index)
        {
            innerList[index].Node.RemoveParentNode();
            innerList.RemoveAt(index);
            for (int childIndex = index; childIndex < innerList.Count; childIndex++)
            {
                innerList[childIndex].Node.Index--;
            }
        }

        private void InternalSet(int index, TChild item)
        {
            innerList[index].Node.RemoveParentNode();
            innerList[index] = item;
            SetParent(item, index);
        }

        private void RefreshList()
        {
            bool isRefreshed = isRefreshList || ((!CodeAnalysisSettings.AreEditsAllowed || IsLocked) && isInitialized);
            isInitialized = true;
            if (isRefreshed)
            {
                return;
            }

            int count = list.Count;
            if (innerList.Count == count)
            {
                return;
            }

            if (CodeAnalysisLogger.LogDebugMessages)
            {
                LogDebugMessage($"RefreshList: listCount={count}, innerListCount={innerList.Count}");
            }

            isRefreshList = true;
            if (innerList.Count < count)
            {
                for (int index = innerList.Count; index < count; index++)
                {
                    TChild child = factory(index);
                    if (child == null)
                    {
                        throw new InvalidOperationException("Child cannot be null");
                    }

                    InternalAdd(child);
                }
            }
            else
            {
                while (innerList.Count > count)
                {
                    INode<TChildSyntax> node = innerList[count].Node;
                    node.IsLocked = true;
                    InternalRemoveAt(count);
                    node.IsLocked = false;
                }
            }

            isRefreshList = false;
        }

        private void LogDebugMessage(string message)
        {
            if (!CodeAnalysisLogger.LogDebugMessages)
            {
                return;
            }

            string genericArguments = string.Join(", ", GetType().GetGenericArguments().Select(type => type.Name));
            string prefix = $"ChildNodeList<{genericArguments}>.";
            CodeAnalysisLogger.LogDebugMessage(prefix + message);
        }
    }
}