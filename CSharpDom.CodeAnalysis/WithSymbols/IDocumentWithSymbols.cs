using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IDocumentWithSymbols : 
        IDocument<IProjectWithSymbols, ISolutionWithSymbols, ILoadedDocumentWithSymbols>,
        IHasDocument<Document>,
        IHasSyntax<IDocumentSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
