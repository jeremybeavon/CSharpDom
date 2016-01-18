using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedInterfaceWithSymbols :
        INestedInterface<ITypeWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IBasicTypeWithSymbols,
        IHasSyntax<INestedInterfaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
