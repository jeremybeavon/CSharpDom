using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Internal
{
    internal sealed class InternalLazyLoadedEnumerable<TFrom, TTo>
    {
        private readonly ICollection<TTo> createdItems;
        private readonly ICollection<TFrom> uncreatedItems;
        private readonly Func<TTo, TFrom> getFunc;

        public InternalLazyLoadedEnumerable(
            IEnumerable<TFrom> originalEnumerable,
            Func<TTo, TFrom> getFunc)
        {
            createdItems = new List<TTo>();
            uncreatedItems = originalEnumerable.ToList();
            this.getFunc = getFunc;
        }

        public IEnumerable<TTo> CreatedItems
        {
            get { return createdItems; }
        }

        public IEnumerable<TFrom> UncreatedItems
        {
            get { return uncreatedItems.ToArray(); }
        }

        public IEnumerable<TTo> GetCreatedItems(Func<TFrom, bool> predicate)
        {
            return createdItems.Where(createdItem => predicate(getFunc(createdItem)));
        }

        public IEnumerable<TFrom> GetUncreatedItems(Func<TFrom, bool> predicate)
        {
            return uncreatedItems.ToArray().Where(predicate);
        }
        
        public void RegisterCreatedItem(TFrom from, TTo to)
        {
            createdItems.Add(to);
            uncreatedItems.Remove(from);
        }
    }
}
