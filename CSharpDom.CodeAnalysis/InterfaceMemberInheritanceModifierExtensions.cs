using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    internal static class InterfaceMemberInheritanceModifierExtensions
    {
        public static SyntaxTokenList ToTokens(
            this InterfaceMemberInheritanceModifier modifier)
        {
            return modifier == InterfaceMemberInheritanceModifier.New ?
                SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.NewKeyword)) :
                SyntaxFactory.TokenList();
        }
    }
}
