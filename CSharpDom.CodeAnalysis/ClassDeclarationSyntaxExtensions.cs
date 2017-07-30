using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
//using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class ClassDeclarationSyntaxExtensions
    {
        public static bool IsAbstractClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.AbstractKeyword) &&
                !syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static bool IsClass(this ClassDeclarationSyntax syntax)
        {
            return !syntax.Modifiers.Any(
                SyntaxKind.AbstractKeyword,
                SyntaxKind.SealedKeyword,
                SyntaxKind.StaticKeyword,
                SyntaxKind.PartialKeyword);
        }

        public static bool IsSealedClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.SealedKeyword) &&
                !syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static bool IsStaticClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.StaticKeyword) &&
                !syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static bool IsAbstractPartialClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.All(SyntaxKind.AbstractKeyword, SyntaxKind.PartialKeyword);
        }

        public static bool IsPartialClass(this ClassDeclarationSyntax syntax)
        {
            return !syntax.Modifiers.Any(
                SyntaxKind.AbstractKeyword,
                SyntaxKind.SealedKeyword,
                SyntaxKind.StaticKeyword) && syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static bool IsSealedPartialClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.All(SyntaxKind.SealedKeyword, SyntaxKind.PartialKeyword);
        }

        public static bool IsStaticPartialClass(this ClassDeclarationSyntax syntax)
        {
            return syntax.Modifiers.All(SyntaxKind.StaticKeyword, SyntaxKind.PartialKeyword);
        }

        public static ClassDeclarationSyntax ToSyntax(
            string name,
            ClassMemberVisibilityModifier visibility,
            params SyntaxKind[] modifiers)
        {
            return ToSyntax(
                name,
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility).AddRange(modifiers));
        }
        
        public static ClassDeclarationSyntax ToSyntax(
            string name,
            TypeVisibilityModifier visibility,
            params SyntaxKind[] modifiers)
        {
            return ToSyntax(
                name,
                default(SyntaxTokenList).WithTypeVisibilityModifier(visibility).AddRange(modifiers));
        }

        public static ClassDeclarationSyntax ToSyntax(string name, SyntaxTokenList modifiers)
        {
            return SyntaxFactory.ClassDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                modifiers,
                SyntaxFactory.Identifier(name),
                null,
                null,
                default(SyntaxList<TypeParameterConstraintClauseSyntax>),
                default(SyntaxList<MemberDeclarationSyntax>));
        }
    }
}
