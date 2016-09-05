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
        where TParentNode : class
        where TParentSyntax : class
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly IList<TChildSyntax> list;
        private readonly Func<TParentNode, TChildNode> factory;
        private readonly Action<TChildNode, TParentNode> setParent;
        private readonly IList<TChildNode> innerList;
        private readonly IDictionary<TChildNode, TChildSyntax> syntaxMap;
        private readonly IDictionary<TChildSyntax, IndexedItem> reverseSyntaxMap;
        private bool isRefreshList;

        public ImmutableListWrapper(
            Node<TParentNode, TParentSyntax> node,
            IList<TChildSyntax> list,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
        {
            this.node = node;
            this.list = list;
            this.factory = factory;
            this.setParent = setParent;
            innerList = new List<TChildNode>();
            syntaxMap = new Dictionary<TChildNode, TChildSyntax>(this);
            reverseSyntaxMap = new Dictionary<TChildSyntax, IndexedItem>();
            //foreach (TChildSyntax syntax in list)
            //{
            //    InternalAdd(factory(node.Value), syntax);
            //}
        }

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
                list[index] = value.Syntax;
                InternalSet(index, value, value.Syntax);
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
            list.Insert(index, item.Syntax);
            InternalInsert(index, item, item.Syntax);
        }

        public void RemoveAt(int index)
        {
            RefreshList();
            list.RemoveAt(index);
            InternalRemoveAt(index, innerList[index], innerList[index].Syntax);
        }

        public void Add(TChildNode item)
        {
            RefreshList();
            list.Add(item.Syntax);
            InternalAdd(item, item.Syntax);
        }

        public void Clear()
        {
            RefreshList();
            while (list.Count != 0)
            {
                list.RemoveAt(0);
                setParent(innerList[0], null);
            }

            innerList.Clear();
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
            list.Remove(item.Syntax);
            return InternalRemove(item, item.Syntax);
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

            return x.InternalId == y.InternalId;
        }

        public int GetHashCode(TChildNode obj)
        {
            return obj == null ? -1 : obj.InternalId.GetHashCode();
        }

        public TChildSyntax GetChild(TChildNode child)
        {
            RefreshList();
            return syntaxMap[child];
        }

        public void SetChild(TChildNode child, TChildSyntax syntax)
        {
            RefreshList();
            list[list.IndexOf(child.Syntax)] = syntax;
        }
        
        private void InternalAdd(TChildNode item, TChildSyntax syntax)
        {
            setParent(item, node.Value);
            innerList.Add(item);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(innerList.Count - 1, item));
        }

        private void InternalInsert(int index, TChildNode item, TChildSyntax syntax)
        {
            setParent(item, node.Value);
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
            setParent(item, null);
            bool result = innerList.Remove(item);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
            return result;
        }

        private void InternalRemoveAt(int index, TChildNode item, TChildSyntax syntax)
        {
            setParent(item, null);
            innerList.RemoveAt(index);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
        }

        private void InternalSet(int index, TChildNode item, TChildSyntax syntax)
        {
            TChildNode oldItem = innerList[index];
            TChildSyntax oldSyntax = oldItem.Syntax;
            setParent(oldItem, null);
            innerList[index] = item;
            setParent(item, node.Value);
            syntaxMap.Remove(oldItem);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Remove(oldSyntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(index, item));
        }

        private void RefreshList()
        {
            if (isRefreshList)
            {
                return;
            }

            isRefreshList = true;
            IList<TChildNode> itemsToDelete = innerList.ToList();
            IList<IndexedItem> itemsToMove = new List<IndexedItem>();
            for (int index = 0; index < list.Count; index++)
            {
                TChildSyntax syntax = list[index];
                IndexedItem item;
                if (!reverseSyntaxMap.TryGetValue(syntax, out item))
                {
                    InternalInsert(index, factory(node.Value), syntax);
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
                InternalRemove(item, item.Syntax);
            }

            foreach (IndexedItem item in itemsToMove)
            {
                InternalInsert(item.Index, item.Item, item.Item.Syntax);
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