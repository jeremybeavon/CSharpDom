using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IDocumentWithSymbols : IDocument,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IHasSyntax<IDocumentSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
