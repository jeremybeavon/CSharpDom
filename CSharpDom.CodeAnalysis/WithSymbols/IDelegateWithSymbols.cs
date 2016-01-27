using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IDelegateWithSymbols :
        IDelegate<INamespaceWithSymbols, IProjectWithSymbols, ISolutionWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<IDelegateSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
