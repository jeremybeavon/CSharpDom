using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDom.Internal
{
    internal sealed class AsyncLazyLoadedEnumerable<TFrom, TTo>
        where TTo : class
    {
        private readonly InternalLazyLoadedEnumerable<TFrom, TTo> enumerable;
        private readonly Func<TFrom, Task<TTo>> asyncCreateFunc;

        public AsyncLazyLoadedEnumerable(
            IEnumerable<TFrom> originalEnumerable,
            Func<TFrom, Task<TTo>> asyncCreateFunc,
            Func<TTo, TFrom> getFunc)
        {
            enumerable = new InternalLazyLoadedEnumerable<TFrom, TTo>(originalEnumerable, getFunc);
            this.asyncCreateFunc = asyncCreateFunc;
        }

        public async Task<TTo> GetItemAsync(Func<TTo, bool> predicate)
        {
            TTo to = enumerable.CreatedItems.Where(predicate).FirstOrDefault();
            if (to != null)
            {
                return to;
            }

            foreach (TFrom from in enumerable.UncreatedItems)
            {
                to = await CreateItemAsync(from);
                if (predicate(to))
                {
                    return to;
                }
            }

            return null;
        }

        public Task<IEnumerable<TTo>> GetAllItems()
        {
            return GetItemsAsync((TTo to) => true);
        }

        public async Task<IEnumerable<TTo>> GetItemsAsync(Func<TTo, bool> predicate)
        {
            ICollection<TTo> items = enumerable.CreatedItems.Where(predicate).ToList();
            foreach (TFrom from in enumerable.UncreatedItems)
            {
                TTo to = await CreateItemAsync(from);
                if (predicate(to))
                {
                    items.Add(to);
                }
            }

            return items;
        }

        public async Task<TTo> GetItemAsync(Func<TFrom, bool> predicate)
        {
            TTo to = enumerable.GetCreatedItems(predicate).FirstOrDefault();
            if (to != null)
            {
                return to;
            }

            TFrom from = enumerable.GetUncreatedItems(predicate).FirstOrDefault();
            return from == null ? null : await CreateItemAsync(from);
        }

        public async Task<IEnumerable<TTo>> GetItemsAsync(Func<TFrom, bool> predicate)
        {
            ICollection<TTo> items = enumerable.GetCreatedItems(predicate).ToList();
            foreach (TFrom from in enumerable.GetUncreatedItems(predicate))
            {
                items.Add(await CreateItemAsync(from));
            }

            return items;
        }

        private async Task<TTo> CreateItemAsync(TFrom from)
        {
            TTo to = await asyncCreateFunc(from);
            enumerable.RegisterCreatedItem(from, to);
            return to;
        }
    }
}
