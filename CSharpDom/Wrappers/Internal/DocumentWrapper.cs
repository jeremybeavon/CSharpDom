using CSharpDom.Common;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DocumentWrapper : AbstractAsyncWrapper<IDocument, Document>
    {
        public DocumentWrapper(IDocument document)
            : base(document)
        {
        }

        public override async Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document)
        {
            Value = new Document()
            {
                FullFilePath = document.FullFilePath,
                LoadedDocument = new LoadedDocumentWrapper(await document.LoadAsync()).Value
            };
        }
    }
}
