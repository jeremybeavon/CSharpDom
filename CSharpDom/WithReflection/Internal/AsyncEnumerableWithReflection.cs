using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class AsyncEnumerableWithReflection<T, TInternal> : IAsyncEnumerable<T, DocumentWithReflection>
    {
        private readonly IAsyncEnumerable<T, DocumentWithReflection> enumerable;
        
        public AsyncEnumerableWithReflection(
            IAsyncEnumerable<TInternal, IDocumentWithReflection> enumerable,
            Func<TInternal, T> fromInternal)
        {
            this.enumerable = new InternalAsyncEnumerable<T, TInternal, DocumentWithReflection, IDocumentWithReflection>(
                enumerable,
                fromInternal,
                document => new DocumentWithReflection(document));
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return enumerable.GetAll();
        }

        public Task<IEnumerable<T>> GetMultiple(
            Func<DocumentWithReflection, bool> documentPredicate,
            Func<T, bool> predicate)
        {
            return enumerable.GetMultiple(documentPredicate, predicate);
        }

        public Task<T> GetSingle(Func<DocumentWithReflection, bool> documentPredicate, Func<T, bool> predicate)
        {
            return enumerable.GetSingle(documentPredicate, predicate);
        }
    }
}
