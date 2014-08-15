using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IStructWithSymbols : IStructWithSymbol,
        IHasDeclarations<IStructDeclarationWithSymbols>,
        IHasNamespace<INamespaceWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        ITypeWithSymbols,
        IHasSyntax<IStructSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
