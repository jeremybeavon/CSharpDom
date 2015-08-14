using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Internal
{
    internal sealed class LazyLoadedEnumerable<TFrom, TTo>
    {
        private readonly InternalLazyLoadedEnumerable<TFrom, TTo> enumerable;
        private readonly Func<TFrom, TTo> createFunc;

        public LazyLoadedEnumerable(
            IEnumerable<TFrom> originalEnumerable,
            Func<TFrom, TTo> createFunc,
            Func<TTo, TFrom> getFunc)
        {
            enumerable = new InternalLazyLoadedEnumerable<TFrom, TTo>(originalEnumerable, getFunc);
            this.createFunc = createFunc;
        }

        public TTo GetItem(Func<TFrom, bool> predicate)
        {
            return GetItems(predicate).FirstOrDefault();
        }

        public IEnumerable<TTo> GetItems(Func<TFrom, bool> predicate)
        {
            IEnumerable<TTo> existingItems = enumerable.GetCreatedItems(predicate);
            IEnumerable<TTo> newItems = enumerable.GetUncreatedItems(predicate).Select(CreateItem);
            return existingItems.Concat(newItems);
        }

        private TTo CreateItem(TFrom from)
        {
            TTo to = createFunc(from);
            enumerable.RegisterCreatedItem(from, to);
            return to;
        }
    }
}
