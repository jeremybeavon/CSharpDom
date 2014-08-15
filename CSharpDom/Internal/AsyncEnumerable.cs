using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Internal
{
    internal sealed class AsyncEnumerable<T, TInternal, TDocument> : IAsyncEnumerable<T, TDocument>
    {
        private readonly IAsyncEnumerable<T, TDocument> asyncEnumerable;

        public AsyncEnumerable(IAsyncEnumerable<TInternal, DocumentNode> asyncEnumerable)
        {
            this.asyncEnumerable = new InternalAsyncEnumerable<T, TInternal, TDocument, DocumentNode>(
                asyncEnumerable,
                item => (T)(object)item,
                document => (TDocument)(object)document);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return asyncEnumerable.GetAll();
        }

        public Task<IEnumerable<T>> GetMultiple(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate)
        {
            return asyncEnumerable.GetMultiple(documentPredicate, predicate);
        }

        public Task<T> GetSingle(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate)
        {
            return asyncEnumerable.GetSingle(documentPredicate, predicate);
        }
    }
}
