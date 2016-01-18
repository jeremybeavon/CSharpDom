using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedDelegateWithSymbols :
        INestedDelegate<ITypeWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedDelegateSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
