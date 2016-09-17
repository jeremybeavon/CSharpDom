using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class BaseCollection<T> : IList<T>
    {
        public T this[int index]
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public abstract int Count { get; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public abstract void Add(T item);

        public abstract void Clear();

        public virtual bool Contains(T item)
        {
            return this.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator<T> GetEnumerator();

        public int IndexOf(T item)
        {
            throw new NotSupportedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotSupportedException();
        }

        public abstract bool Remove(T item);

        public void RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
