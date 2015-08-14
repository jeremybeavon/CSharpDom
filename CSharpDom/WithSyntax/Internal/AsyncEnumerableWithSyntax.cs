using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;

namespace CSharpDom.WithSyntax.Internal
{
    internal sealed class AsyncEnumerableWithSyntax<T, TInternal> : IAsyncEnumerable<T, DocumentWithSyntax>
    {
        private readonly IAsyncEnumerable<T, DocumentWithSyntax> enumerable;
        
        public AsyncEnumerableWithSyntax(
            IAsyncEnumerable<TInternal, IDocumentSyntax> enumerable,
            Func<TInternal, T> fromInternal)
        {
            this.enumerable = new InternalAsyncEnumerable<T, TInternal, DocumentWithSyntax, IDocumentSyntax>(
                enumerable,
                fromInternal,
                document => new DocumentWithSyntax(document));
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return enumerable.GetAll();
        }

        public Task<IEnumerable<T>> GetMultiple(
            Func<DocumentWithSyntax, bool> documentPredicate,
            Func<T, bool> predicate)
        {
            return enumerable.GetMultiple(documentPredicate, predicate);
        }

        public Task<T> GetSingle(Func<DocumentWithSyntax, bool> documentPredicate, Func<T, bool> predicate)
        {
            return enumerable.GetSingle(documentPredicate, predicate);
        }
    }
}
