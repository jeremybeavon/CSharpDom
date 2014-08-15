using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface IStructDeclarationWithSymbols : IStructWithSymbol, IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<IStructWithSymbols>,
        IHasDocument<IDocumentWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        ITypeWithSymbols,
        IHasSyntax<IStructDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
