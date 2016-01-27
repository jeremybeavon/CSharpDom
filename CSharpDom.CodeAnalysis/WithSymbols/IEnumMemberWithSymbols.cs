using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IEnumMemberWithSymbols :
        IEnumMember<IEnumWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<IEnumMemberSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
