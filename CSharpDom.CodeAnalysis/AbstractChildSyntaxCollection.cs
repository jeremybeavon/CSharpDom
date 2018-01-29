using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractChildSyntaxCollection<TParentSyntax, TChildSyntax> :
        IChildSyntaxList<TParentSyntax, TChildSyntax>
    {
        public abstract TChildSyntax this[int index] { get; }

        TChildSyntax IList<TChildSyntax>.this[int index]
        {
            get { return this[index]; }
            set { throw new NotSupportedException(); }
        }

        public abstract int Count { get; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public abstract void Add(TChildSyntax item);

        public abstract void Clear();

        public virtual bool Contains(TChildSyntax item)
        {
            return this.Contains(item);
        }

        public void CopyTo(TChildSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator<TChildSyntax> GetEnumerator();

        public int IndexOf(TChildSyntax item)
        {
            throw new NotSupportedException();
        }

        public void Insert(int index, TChildSyntax item)
        {
            throw new NotSupportedException();
        }

        public abstract bool Remove(TChildSyntax item);

        public void RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        public TParentSyntax Set(int index, TChildSyntax value)
        {
            throw new NotSupportedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
