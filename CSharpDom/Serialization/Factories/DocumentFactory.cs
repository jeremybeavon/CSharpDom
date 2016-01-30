using CSharpDom.Common;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories
{
    public sealed class DocumentFactory : AbstractAsyncFactory<IDocument, Document>
    {
        public DocumentFactory(IDocument document)
            : base(document)
        {
        }

        public override async Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document)
        {
            Value = new Document()
            {
                FullFilePath = document.FullFilePath,
                LoadedDocument = new LoadedDocumentFactory(await document.LoadAsync()).Value
            };
        }
    }
}
