using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface IEnumMemberWithSymbols : IEnumMember,
        IHasDeclaringType<IEnumWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<IEnumMemberSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
