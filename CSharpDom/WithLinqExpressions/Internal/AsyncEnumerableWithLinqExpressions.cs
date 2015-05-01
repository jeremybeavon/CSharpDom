using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class AsyncEnumerableWithLinqExpressions<T, TInternal> : IAsyncEnumerable<T, DocumentWithLinqExpressions>
    {
        private readonly IAsyncEnumerable<T, DocumentWithLinqExpressions> enumerable;
        
        public AsyncEnumerableWithLinqExpressions(
            IAsyncEnumerable<TInternal, IDocumentWithLinqExpressions> enumerable,
            Func<TInternal, T> fromInternal)
        {
            this.enumerable = new InternalAsyncEnumerable<T, TInternal, DocumentWithLinqExpressions, IDocumentWithLinqExpressions>(
                enumerable,
                fromInternal,
                document => new DocumentWithLinqExpressions(document));
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return enumerable.GetAll();
        }

        public Task<IEnumerable<T>> GetMultiple(
            Func<DocumentWithLinqExpressions, bool> documentPredicate,
            Func<T, bool> predicate)
        {
            return enumerable.GetMultiple(documentPredicate, predicate);
        }

        public Task<T> GetSingle(Func<DocumentWithLinqExpressions, bool> documentPredicate, Func<T, bool> predicate)
        {
            return enumerable.GetSingle(documentPredicate, predicate);
        }
    }
}
