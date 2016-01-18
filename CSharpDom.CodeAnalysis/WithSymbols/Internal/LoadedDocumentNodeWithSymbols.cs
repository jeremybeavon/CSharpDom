using CSharpDom.CodeAnalysis.WithSyntax.Internal;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class LoadedDocumentNodeWithSymbols : LoadedDocumentNodeWithSyntax
    {
        public LoadedDocumentNodeWithSymbols(DocumentNode document)
            : base(document)
        {
        }
    }
}
