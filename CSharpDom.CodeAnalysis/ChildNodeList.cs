using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        IList<TChildNode>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly IChildSyntaxList<TParentSyntax, TChildSyntax> list;
        private readonly Func<TChildSyntax, TChildNode> factoryWithSyntax;
        private readonly Func<TChildNode> factory;
        private readonly IList<TChildNode> innerList;
        private bool isInitialized;
        private bool isRefreshList;

        public ChildNodeList(
            Node<TParentNode, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChildNode> factory)
            : this(node, list)
        {
            this.factory = factory;
        }

        public ChildNodeList(
            Node<TParentNode, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChildSyntax, TChildNode> factory)
            : this(node, list)
        {
            factoryWithSyntax = factory;
        }

        private ChildNodeList(
            Node<TParentNode, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list)
        {
            this.node = node;
            this.list = list;
            innerList = new List<TChildNode>();
        }

        public bool IsLocked { get; set; }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public TChildNode this[int index]
        {
            get
            {
                RefreshList();
                return innerList[index];
            }
            set
            {
                RefreshList();
                isRefreshList = true;
                list[index] = value.Node.Syntax;
                InternalSet(index, value);
                isRefreshList = false;
            }
        }
        
        public int IndexOf(TChildNode item)
        {
            RefreshList();
            return innerList.IndexOf(item);
        }

        public void Insert(int index, TChildNode item)
        {
            RefreshList();
            isRefreshList = true;
            TChildSyntax syntax = item.Node.Syntax;
            list.Insert(index, syntax);
            InternalInsert(index, item, syntax);
            isRefreshList = false;
        }

        public void RemoveAt(int index)
        {
            RefreshList();
            isRefreshList = true;
            list.RemoveAt(index);
            InternalRemoveAt(index);
            isRefreshList = false;
        }

        public void Add(TChildNode item)
        {
            RefreshList();
            isRefreshList = true;
            list.Add(item.Node.Syntax);
            InternalAdd(item);
            isRefreshList = false;
        }

        public void Clear()
        {
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

        public bool Contains(TChildNode item)
        {
            RefreshList();
            return innerList.Contains(item);
        }

        public void CopyTo(TChildNode[] array, int arrayIndex)
        {
            RefreshList();
            innerList.CopyTo(array, arrayIndex);
        }

        public bool Remove(TChildNode item)
        {
            RefreshList();
            isRefreshList = true;
            TChildSyntax syntax = item.Node.Syntax;
            list.Remove(syntax);
            bool isRemoved = InternalRemove(item);
            isRefreshList = false;
            return isRefreshList;
        }

        public IEnumerator<TChildNode> GetEnumerator()
        {
            RefreshList();
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public TChildSyntax GetChildSyntax(TParentSyntax parentSyntax, int index)
        {
            return list[index];
        }

        public TParentSyntax CreateChildSyntax(TParentSyntax parentSyntax, int index, TChildSyntax childSyntax)
        {
            return list.Set(index, childSyntax);
        }

        private void SetParentNode(TChildNode item, int initialIndex)
        {
            item.Node.SetParentNode<TParentNode, TParentSyntax>(
                node.Value,
                initialIndex,
                GetChildSyntax,
                CreateChildSyntax);
        }
        
        private void InternalAdd(TChildNode item)
        {
            innerList.Add(item);
            SetParentNode(item, innerList.Count - 1);
        }

        private void InternalInsert(int index, TChildNode item, TChildSyntax syntax)
        {
            innerList.Insert(index, item);
            for (int childIndex = index; childIndex < innerList.Count; index++)
            {
                innerList[childIndex].Node.Index++;
            }

            SetParentNode(item, index);
        }

        private void InternalClear()
        {
            innerList.Clear();
        }

        private bool InternalRemove(TChildNode item)
        {
            item.Node.RemoveParentNode();
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

        private void InternalSet(int index, TChildNode item)
        {
            innerList[index].Node.RemoveParentNode();
            innerList[index] = item;
            SetParentNode(item, index);
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
            if (innerList.Count == list.Count)
            {
                return;
            }

            isRefreshList = true;
            if (innerList.Count < count)
            {
                for (int index = innerList.Count; index < count; index++)
                {
                    InternalAdd(factory == null ? factoryWithSyntax(list[index]) : factory());
                }
            }
            else
            {
                while (innerList.Count > count)
                {
                    InternalRemoveAt(count);
                }
            }

            isRefreshList = false;
        }
    }
}