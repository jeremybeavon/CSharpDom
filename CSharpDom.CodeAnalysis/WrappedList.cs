﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal class WrappedList<TParent, TChild> : IList<TChild>
        where TChild : class
    {
        private readonly IList<TParent> list;
        private readonly Func<TParent, TChild> toChild;
        private readonly Func<TChild, TParent> toParent;
        private readonly Func<TChild, bool> filter;

        public WrappedList(
            IList<TParent> list,
            Func<TParent, TChild> toChild,
            Func<TChild, TParent> toParent,
            Func<TChild, bool> filter = null)
        {
            this.list = list;
            this.toChild = toChild;
            this.toParent = toParent;
            this.filter = filter;
        }

        public int Count
        {
            get { return ChildList.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public TChild this[int index]
        {
            get { return ChildList.ElementAt(index); }
            set { list[list.IndexOf(toParent(this[index]))] = toParent(value); }
        }

        private IEnumerable<TChild> ChildList
        {
            get
            {
                IEnumerable<TChild> childList = list.Select(toChild).Where(child => child != null);
                return filter == null ? childList : childList.Where(filter);
            }
        }

        public void Add(TChild item)
        {
            list.Insert(IndexOf(ChildList.Last()) + 1, toParent(item));
        }

        public void Clear()
        {
            foreach (TParent item in list)
            {
                list.Remove(item);
            }
        }

        public bool Contains(TChild item)
        {
            return ChildList.Contains(item);
        }

        public void CopyTo(TChild[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<TChild> GetEnumerator()
        {
            return ChildList.GetEnumerator();
        }

        public int IndexOf(TChild item)
        {
            int index = 0;
            foreach (TChild child in ChildList)
            {
                if (Equals(child, item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public void Insert(int index, TChild item)
        {
            list.Insert(IndexOf(this[index]), toParent(item));
        }

        public bool Remove(TChild item)
        {
            list.RemoveAt(IndexOf(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            Remove(this[index]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}