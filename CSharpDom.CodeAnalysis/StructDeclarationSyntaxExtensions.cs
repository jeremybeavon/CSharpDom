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

        public static StructDeclarationSyntax ToPartialSyntax(string name, ClassMemberVisibilityModifier visibility)
        {
            return ToSyntax(name, visibility, SyntaxKind.PartialKeyword);
        }

        public static StructDeclarationSyntax ToSyntax(
            string name,
            ClassMemberVisibilityModifier visibility,
            params SyntaxKind[] modifiers)
        {
            return ToSyntax(
                name,
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility).AddRange(modifiers));
        }

        public static StructDeclarationSyntax ToSyntax(
            string name,
            StructMemberVisibilityModifier visibility,
            params SyntaxKind[] modifiers)
        {
            return ToSyntax(
                name,
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility).AddRange(modifiers));
        }

        public static StructDeclarationSyntax ToSyntax(string name, SyntaxTokenList modifiers)
        {
            return SyntaxFactory.StructDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                modifiers,
                SyntaxFactory.Identifier(name),
                SyntaxFactory.TypeParameterList(),
                SyntaxFactory.BaseList(),
                default(SyntaxList<TypeParameterConstraintClauseSyntax>),
                default(SyntaxList<MemberDeclarationSyntax>));
        }
    }
}
