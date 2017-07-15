using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class WrappedCollection<TParent, TChild> : ICollection<TChild>
    {
        private readonly ICollection<TParent> collection;
        private readonly Func<TParent, TChild> toChild;
        private readonly Func<TChild, TParent> toParent;
        private readonly Action<ICollection<TParent>> replaceAction;

        public WrappedCollection(
            ICollection<TParent> collection,
            Func<TParent, TChild> toChild,
            Func<TChild, TParent> toParent,
            Action<ICollection<TParent>> replaceAction)
        {
            this.collection = collection;
            this.toChild = toChild;
            this.toParent = toParent;
            this.replaceAction = replaceAction;
        }

        public int Count => collection.Count;

        public bool IsReadOnly => collection.IsReadOnly;

        public void Add(TChild item)
        {
            collection.Add(toParent(item));
        }

        public void Clear()
        {
            collection.Clear();
        }

        public bool Contains(TChild item)
        {
            return collection.Contains(toParent(item));
        }

        public void CopyTo(TChild[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<TChild> GetEnumerator()
        {
            return collection.Select(toChild).GetEnumerator();
        }

        public bool Remove(TChild item)
        {
            return collection.Remove(toParent(item));
        }

        public void Replace(ICollection<TChild> childCollection)
        {
            replaceAction(new ReadOnlyEnumerableCollection<TParent>(childCollection.Select(toParent)));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
