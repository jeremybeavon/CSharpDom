using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CSharpDom
{
    internal sealed class ReadOnlyAggregateCollection<T, TParent> : IReadOnlyCollection<T>
    {
        private readonly Collection<TParent> collection;
        private readonly Func<TParent, IReadOnlyCollection<T>> selectFunc;

        public ReadOnlyAggregateCollection(Collection<TParent> collection, Func<TParent, IReadOnlyCollection<T>> selectFunc)
        {
            this.collection = collection;
            this.selectFunc = selectFunc;
        }

        public int Count
        {
            get { return collection.Sum(parent => selectFunc(parent).Count); }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return collection.SelectMany(selectFunc).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
