using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface INestedEnumWithSymbols : IEnum, IHasDeclaringType<ITypeWithSymbols>,
        IHasEnumMembers<INestedEnumMemberWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedEnumSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
