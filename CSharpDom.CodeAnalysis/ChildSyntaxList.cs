﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ChildSyntaxList<TParent, TParentSyntax, TChildList, TChildSyntax> :
        IChildSyntaxList<TParentSyntax, TChildSyntax>
        where TParentSyntax : class
        where TChildList : IReadOnlyList<TChildSyntax>
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly IImmutableList<TChildList, TChildSyntax> immutableList;
        private readonly Func<TParentSyntax, TChildList> getList;
        private readonly Func<TParentSyntax, TChildList, TParentSyntax> createList;

        public ChildSyntaxList(
            Node<TParent, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
        {
            this.node = node;
            this.immutableList = immutableList;
            this.getList = getList;
            this.createList = createList;
        }

        public ChildSyntaxList(
            Node<TParent, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            IChildSyntaxListConversions<TParentSyntax, TChildList> conversions)
            : this(node, immutableList, conversions.GetList, conversions.CreateList)
        {
        }

        public int Count
        {
            get { return getList(node.Syntax).Count; }
        }

        public bool IsReadOnly => false;

        public TChildSyntax this[int index]
        {
            get { return getList(node.Syntax)[index]; }
            set
            {
                TChildSyntax currentSyntax = this[index];
                if (!Equals(currentSyntax, value))
                {
                    node.Syntax = UpdateList(childList => immutableList.Replace(childList, currentSyntax, value));
                }
            }
        }

        public TParentSyntax Set(int index, TChildSyntax value)
        {
            TChildSyntax currentSyntax = this[index];
            if (!Equals(currentSyntax, value))
            {
                return UpdateList(childList => immutableList.Replace(childList, currentSyntax, value));
            }

            return node.Syntax;
        }

        public void Add(TChildSyntax item)
        {
            node.Syntax = UpdateList(childList => immutableList.Add(childList, item));
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
            return getList(node.Syntax).GetEnumerator();
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
            node.Syntax = UpdateList(childList => immutableList.Insert(childList, index, item));
        }

        public bool Remove(TChildSyntax item)
        {
            node.Syntax = UpdateList(childList => immutableList.Remove(childList, item));
            return true;
        }

        public void RemoveAt(int index)
        {
            node.Syntax = UpdateList(childList => immutableList.RemoveAt(childList, index));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private TParentSyntax UpdateList(Func<TChildList, TChildList> updateFunc)
        {
            TParentSyntax syntax = node.Syntax;
            return createList(syntax, updateFunc(getList(syntax)));
        }
    }
}
