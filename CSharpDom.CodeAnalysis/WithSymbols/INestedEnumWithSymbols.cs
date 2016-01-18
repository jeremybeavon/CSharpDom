using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedEnumWithSymbols :
        INestedEnum<ITypeWithSymbols, INestedEnumMemberWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedEnumSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
