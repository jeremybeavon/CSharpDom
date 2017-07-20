using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class StructDeclarationSyntaxExtensions
    {
        public static bool IsPartial(this StructDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static StructDeclarationSyntax ToPartialSyntax(string name)
        {
            return SyntaxFactory.StructDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PartialKeyword)),
                SyntaxFactory.Identifier(name),
                SyntaxFactory.TypeParameterList(),
                SyntaxFactory.BaseList(),
                default(SyntaxList<TypeParameterConstraintClauseSyntax>),
                default(SyntaxList<MemberDeclarationSyntax>));
        }
    }
}
