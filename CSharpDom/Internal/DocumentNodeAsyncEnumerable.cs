using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Internal
{
    internal sealed class DocumentNodeAsyncEnumerable<T> : IAsyncEnumerable<T, DocumentNode>
    {
        private readonly AsyncLazyLoadedEnumerable<DocumentNode, AnalyzedDocument> analyzedDocuments;
        private readonly Func<AnalyzedDocument, IEnumerable<T>> selectFunc;

        public DocumentNodeAsyncEnumerable(
            AsyncLazyLoadedEnumerable<DocumentNode, AnalyzedDocument> analyzedDocuments,
            Func<AnalyzedDocument, IEnumerable<T>> selectFunc)
        {
            this.analyzedDocuments = analyzedDocuments;
            this.selectFunc = selectFunc;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return (await analyzedDocuments.GetAllItems()).SelectMany(selectFunc);
        }

        public async Task<IEnumerable<T>> GetMultiple(
            Func<DocumentNode, bool> documentPredicate,
            Func<T, bool> predicate)
        {
            return (await analyzedDocuments.GetItemsAsync(documentPredicate)).SelectMany(selectFunc).Where(predicate);
        }

        public async Task<T> GetSingle(Func<DocumentNode, bool> documentPredicate, Func<T, bool> predicate)
        {
            return selectFunc(await analyzedDocuments.GetItemAsync(documentPredicate)).FirstOrDefault(predicate);
        }
    }
}
