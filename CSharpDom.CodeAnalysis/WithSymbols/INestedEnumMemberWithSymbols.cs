using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedEnumMemberWithSymbols :
        IEnumMember<INestedEnumWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<INestedEnumMemberSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
