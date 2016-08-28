using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ImmutableChildListWrapper<TParentNode, TParentSyntax, TChildList, TChildSyntax> : IList<TChildSyntax>
        where TParentSyntax : class
        where TChildList : IReadOnlyList<TChildSyntax>
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly IImmutableList<TChildList, TChildSyntax> immutableList;
        private readonly Func<TParentSyntax, TChildList> getList;
        private readonly Func<TParentSyntax, TChildList, TParentSyntax> createList;

        public ImmutableChildListWrapper(
            Node<TParentNode, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
        {
            this.node = node;
            this.immutableList = immutableList;
            this.getList = getList;
            this.createList = createList;
        }

        public TChildSyntax this[int index]
        {
            get { return getList(node.Syntax)[index]; }
            set { UpdateList(childList => immutableList.Replace(childList, this[index], value)); }
        }

        public int Count
        {
            get { return getList(node.Syntax).Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(TChildSyntax item)
        {
            UpdateList(childList => immutableList.Add(childList, item));
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(TChildSyntax item)
        {
            return getList(node.Syntax).Contains(item);
        }

        public void CopyTo(TChildSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<TChildSyntax> GetEnumerator()
        {
            return ((IEnumerable<TChildSyntax>)getList(node.Syntax)).GetEnumerator();
        }

        public int IndexOf(TChildSyntax item)
        {
            int index = 0;
            foreach (TChildSyntax syntax in this)
            {
                if (Equals(syntax, item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public void Insert(int index, TChildSyntax item)
        {
            UpdateList(childList => immutableList.Insert(childList, index, item));
        }

        public bool Remove(TChildSyntax item)
        {
            UpdateList(childList => immutableList.Remove(childList, item));
            return true;
        }

        public void RemoveAt(int index)
        {
            UpdateList(childList => immutableList.RemoveAt(childList, index));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void UpdateList(Func<TChildList, TChildList> updateFunc)
        {
            TParentSyntax syntax = node.Syntax;
            node.Syntax = createList(syntax, updateFunc(getList(syntax)));
        }
    }
}
