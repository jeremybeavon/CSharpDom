using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IInterfaceWithSymbols :
        IInterface<INamespaceWithSymbols, IProjectWithSymbols, ISolutionWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IBasicTypeWithSymbols,
        IHasSyntax<IInterfaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
