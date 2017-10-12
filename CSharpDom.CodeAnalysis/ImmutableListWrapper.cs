using Microsoft.CodeAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        IList<TChildNode>,
        IEqualityComparer<TChildNode>,
        IChildCollection<TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly IList<TChildSyntax> list;
        private readonly Func<TChildSyntax, TChildNode> factory;
        private readonly IList<TChildNode> innerList;
        private readonly IDictionary<TChildNode, TChildSyntax> syntaxMap;
        private readonly IDictionary<TChildSyntax, IndexedItem> reverseSyntaxMap;
        private bool isInitialized;
        private bool isRefreshList;

        public ImmutableListWrapper(
            Node<TParentNode, TParentSyntax> node,
            IList<TChildSyntax> list,
            Func<TChildNode> factory)
            : this(node, list, syntax => factory())
        {
        }

        public ImmutableListWrapper(
            Node<TParentNode, TParentSyntax> node,
            IList<TChildSyntax> list,
            Func<TChildSyntax, TChildNode> factory)
        {
            this.node = node;
            this.list = list;
            this.factory = factory;
            innerList = new List<TChildNode>();
            syntaxMap = new Dictionary<TChildNode, TChildSyntax>(this);
            reverseSyntaxMap = new Dictionary<TChildSyntax, IndexedItem>();
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
                InternalSet(index, value, value.Node.Syntax);
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
            InternalRemoveAt(index, innerList[index], innerList[index].Node.Syntax);
            isRefreshList = false;
        }

        public void Add(TChildNode item)
        {
            RefreshList();
            isRefreshList = true;
            TChildSyntax syntax = item.Node.Syntax;
            list.Add(syntax);
            InternalAdd(item, syntax);
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
            bool isRemoved = InternalRemove(item, syntax);
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

        public bool Equals(TChildNode x, TChildNode y)
        {
            if (Equals((object)x, y))
            {
                return true;
            }

            return x.Node.InternalId == y.Node.InternalId;
        }

        public int GetHashCode(TChildNode obj)
        {
            return obj == null ? -1 : obj.Node.InternalId.GetHashCode();
        }

        public TChildSyntax GetChild(TChildNode child)
        {
            RefreshList();
            return syntaxMap[child];
        }

        public void SetChild(TChildNode child, TChildSyntax syntax)
        {
            RefreshList();
            isRefreshList = true;
            TChildSyntax oldSyntax = child.Node.Syntax;
            IndexedItem oldIndexedItem = reverseSyntaxMap[oldSyntax];
            list[oldIndexedItem.Index] = syntax;
            TChildSyntax newSyntax = list[oldIndexedItem.Index];
            syntaxMap[child] = newSyntax;
            reverseSyntaxMap.Remove(oldSyntax);
            reverseSyntaxMap.Add(newSyntax, new IndexedItem(oldIndexedItem.Index, child));
            isRefreshList = false;
        }
        
        private void InternalAdd(TChildNode item, TChildSyntax syntax)
        {
            item.Node.SetParentNode<TParentNode, TParentSyntax, TChildNode>(node.Value, item, this);
            innerList.Add(item);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(innerList.Count - 1, item));
        }

        private void InternalInsert(int index, TChildNode item, TChildSyntax syntax)
        {
            item.Node.SetParentNode<TParentNode, TParentSyntax, TChildNode>(node.Value, item, this);
            innerList.Insert(index, item);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(index, item));
        }

        private void InternalClear()
        {
            innerList.Clear();
            syntaxMap.Clear();
            reverseSyntaxMap.Clear();
        }

        private bool InternalRemove(TChildNode item, TChildSyntax syntax)
        {
            item.Node.RemoveParentNode();
            bool result = innerList.Remove(item);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
            return result;
        }

        private void InternalRemoveAt(int index, TChildNode item, TChildSyntax syntax)
        {
            item.Node.RemoveParentNode();
            innerList.RemoveAt(index);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
        }

        private void InternalSet(int index, TChildNode item, TChildSyntax syntax)
        {
            TChildNode oldItem = innerList[index];
            TChildSyntax oldSyntax = oldItem.Node.Syntax;
            oldItem.Node.RemoveParentNode();
            innerList[index] = item;
            item.Node.SetParentNode<TParentNode, TParentSyntax, TChildNode>(node.Value, item, this);
            syntaxMap.Remove(oldItem);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Remove(oldSyntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(index, item));
        }

        private void RefreshList()
        {
            bool isRefreshed = isRefreshList || ((CodeAnalysisSettings.SkipRefreshes || IsLocked) && isInitialized);
            isInitialized = true;
            if (isRefreshed)
            {
                return;
            }

            isRefreshList = true;
            IList<TChildNode> itemsToDelete = innerList.ToList();
            IList<IndexedItem> itemsToMove = new List<IndexedItem>();
            for (int index = 0; index < list.Count; index++)
            {
                TChildSyntax syntax = list[index];
                if (!reverseSyntaxMap.TryGetValue(syntax, out IndexedItem item))
                {
                    InternalInsert(index, factory(syntax), syntax);
                }
                else if (item.Index != index)
                {
                    itemsToMove.Add(new IndexedItem(index, item.Item));
                }
                else
                {
                    itemsToDelete.Remove(item.Item);
                }
            }

            foreach (TChildNode item in itemsToDelete)
            {
                InternalRemove(item, item.Node.Syntax);
            }

            foreach (IndexedItem item in itemsToMove)
            {
                InternalInsert(item.Index, item.Item, item.Item.Node.Syntax);
            }

            isRefreshList = false;
        }

        private sealed class IndexedItem
        {
            public IndexedItem(int index, TChildNode item)
            {
                Index = index;
                Item = item;
            }

            public int Index { get; set; }

            public TChildNode Item { get; set; }
        }
    }
}