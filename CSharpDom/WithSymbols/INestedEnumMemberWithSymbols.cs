using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface INestedEnumMemberWithSymbols : IEnumMember,
        IHasDeclaringType<INestedEnumWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<INestedEnumMemberSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
