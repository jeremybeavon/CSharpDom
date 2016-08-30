using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredList<TParent, TChild> : IList<TChild>
        where TChild : TParent
    {
        private readonly IList<TParent> list;
        private readonly Func<TChild, bool> filter;

        public FilteredList(IList<TParent> list, Func<TChild, bool> filter = null)
        {
            this.list = list;
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
            set { list[list.IndexOf(this[index])] = value; }
        }

        private IEnumerable<TChild> ChildList
        {
            get
            {
                IEnumerable<TChild> childList = list.OfType<TChild>();
                return filter == null ? childList : childList.Where(filter);
            }
        }

        public void Add(TChild item)
        {
            list.Insert(list.IndexOf(ChildList.Last()) + 1, item);
        }

        public void Clear()
        {
            foreach (TParent item in ChildList)
            {
                list.Remove(item);
            }
        }

        public bool Contains(TChild item)
        {
            return list.Contains(item);
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
            list.Insert(list.IndexOf(this[index]), item);
        }

        public bool Remove(TChild item)
        {
            return list.Remove(item);
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
