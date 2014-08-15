using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IInterfaceWithSymbols : IInterfaceWithSymbol, IBasicTypeWithSymbols,
        IHasDeclarations<IInterfaceDeclarationWithSymbols>,
        IHasNamespace<INamespaceWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IHasSyntax<IInterfaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
