using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;

namespace CSharpDom.WithSymbols.Internal
{
    internal sealed class AsyncEnumerableWithSymbols<T, TInternal> : IAsyncEnumerable<T, DocumentWithSymbols>
    {
        private readonly IAsyncEnumerable<T, DocumentWithSymbols> enumerable;
        
        public AsyncEnumerableWithSymbols(
            IAsyncEnumerable<TInternal, IDocumentWithSymbols> enumerable,
            Func<TInternal, T> fromInternal)
        {
            this.enumerable = new InternalAsyncEnumerable<T, TInternal, DocumentWithSymbols, IDocumentWithSymbols>(
                enumerable,
                fromInternal,
                document => new DocumentWithSymbols(document));
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return enumerable.GetAll();
        }

        public Task<IEnumerable<T>> GetMultiple(
            Func<DocumentWithSymbols, bool> documentPredicate,
            Func<T, bool> predicate)
        {
            return enumerable.GetMultiple(documentPredicate, predicate);
        }

        public Task<T> GetSingle(Func<DocumentWithSymbols, bool> documentPredicate, Func<T, bool> predicate)
        {
            return enumerable.GetSingle(documentPredicate, predicate);
        }
    }
}
