using Microsoft.CodeAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ImmutableListWrapper<T, TSyntax, TParent> : IList<T>, IEqualityComparer<T>
        where T : class, IHasSyntax<TSyntax>, IHasId
        where TParent : class
    {
        private readonly IList<TSyntax> list;
        private readonly Func<T> factory;
        private readonly TParent parent;
        private readonly Action<T, TParent> setParent;
        private readonly IList<T> innerList;
        private readonly IDictionary<T, TSyntax> syntaxMap;
        private readonly IDictionary<TSyntax, IndexedItem> reverseSyntaxMap;
        private bool isRefreshList;

        public ImmutableListWrapper(IList<TSyntax> list, Func<T> factory, TParent parent, Action<T, TParent> setParent)
        {
            this.list = list;
            this.factory = factory;
            syntaxMap = new Dictionary<T, TSyntax>(this);
            reverseSyntaxMap = new Dictionary<TSyntax, IndexedItem>();
            foreach (TSyntax syntax in list)
            {
                InternalAdd(factory(), syntax);
            }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public T this[int index]
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

        public int IndexOf(T item)
        {
            RefreshList();
            return innerList.IndexOf(item);
        }

        public void Insert(int index, T item)
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

        public void Add(T item)
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

        public bool Contains(T item)
        {
            RefreshList();
            return innerList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            RefreshList();
            innerList.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            RefreshList();
            list.Remove(item.Syntax);
            return InternalRemove(item, item.Syntax);
        }

        public IEnumerator<T> GetEnumerator()
        {
            RefreshList();
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Equals(T x, T y)
        {
            if (Equals((object)x, y))
            {
                return true;
            }

            return x.InternalId == y.InternalId;
        }

        public int GetHashCode(T obj)
        {
            return obj == null ? -1 : obj.InternalId.GetHashCode();
        }

        public TSyntax GetChild(T child)
        {
            RefreshList();
            return syntaxMap[child];
        }

        public void SetChild(T child, TSyntax syntax)
        {
            RefreshList();
            list[list.IndexOf(child.Syntax)] = syntax;
        }

        private T CreateChild(int index, TSyntax syntax)
        {
            T child = factory();
            syntaxMap.Add(child, syntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(index, child));
            setParent(child, parent);
            return child;
        }

        private void InternalAdd(T item, TSyntax syntax)
        {
            setParent(item, parent);
            innerList.Add(item);
            syntaxMap.Add(item, syntax);
            reverseSyntaxMap.Add(syntax, new IndexedItem(innerList.Count - 1, item));
        }

        private void InternalInsert(int index, T item, TSyntax syntax)
        {
            setParent(item, parent);
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

        private bool InternalRemove(T item, TSyntax syntax)
        {
            setParent(item, null);
            bool result = innerList.Remove(item);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
            return result;
        }

        private void InternalRemoveAt(int index, T item, TSyntax syntax)
        {
            setParent(item, null);
            innerList.RemoveAt(index);
            syntaxMap.Remove(item);
            reverseSyntaxMap.Remove(syntax);
        }

        private void InternalSet(int index, T item, TSyntax syntax)
        {
            T oldItem = innerList[index];
            TSyntax oldSyntax = oldItem.Syntax;
            setParent(oldItem, null);
            innerList[index] = item;
            setParent(item, parent);
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
            IList<T> itemsToDelete = innerList.ToList();
            IList<IndexedItem> itemsToMove = new List<IndexedItem>();
            for (int index = 0; index < list.Count; index++)
            {
                TSyntax syntax = list[index];
                IndexedItem item;
                if (!reverseSyntaxMap.TryGetValue(syntax, out item))
                {
                    InternalInsert(index, factory(), syntax);
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

            foreach (T item in itemsToDelete)
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
            public IndexedItem(int index, T item)
            {
                Index = index;
                Item = item;
            }

            public int Index { get; set; }

            public T Item { get; set; }
        }
    }
}