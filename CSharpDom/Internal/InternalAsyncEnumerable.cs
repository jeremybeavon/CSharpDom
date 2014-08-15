using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Internal
{
    internal sealed class InternalAsyncEnumerable<T, TInternal, TDocument, TInternalDocument> :
        IAsyncEnumerable<T, TDocument>
    {
        private readonly IAsyncEnumerable<TInternal, TInternalDocument> asyncEnumerable;
        private readonly Func<TInternal, T> fromInternal;
        private readonly Func<TInternalDocument, TDocument> fromInternalDocument;

        public InternalAsyncEnumerable(
            IAsyncEnumerable<TInternal, TInternalDocument> asyncEnumerable,
            Func<TInternal, T> fromInternal,
            Func<TInternalDocument, TDocument> fromInternalDocument)
        {
            this.asyncEnumerable = asyncEnumerable;
            this.fromInternal = fromInternal;
            this.fromInternalDocument = fromInternalDocument;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return (await asyncEnumerable.GetAll()).Cast<T>();
        }

        public async Task<IEnumerable<T>> GetMultiple(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate)
        {
            Func<TInternalDocument, bool> internalDocumentPredicate = GetDocumentPredicate(documentPredicate);
            Func<TInternal, bool> internalPredicate = GetPredicate(predicate);
            return (await asyncEnumerable.GetMultiple(internalDocumentPredicate, internalPredicate)).Cast<T>();
        }

        public async Task<T> GetSingle(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate)
        {
            Func<TInternalDocument, bool> internalDocumentPredicate = GetDocumentPredicate(documentPredicate);
            Func<TInternal, bool> internalPredicate = GetPredicate(predicate);
            return (T)(object)(await asyncEnumerable.GetSingle(internalDocumentPredicate, internalPredicate));
        }

        private Func<TInternalDocument, bool> GetDocumentPredicate(Func<TDocument, bool> documentPredicate)
        {
            return document => documentPredicate(fromInternalDocument(document));
        }

        private Func<TInternal, bool> GetPredicate(Func<T, bool> predicate)
        {
            return item => predicate(fromInternal(item));
        }
    }
}