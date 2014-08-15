using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IDelegateWithSymbols : IDelegateWithSymbol,
        IHasNamespace<INamespaceWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IHasSyntax<IDelegateSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
