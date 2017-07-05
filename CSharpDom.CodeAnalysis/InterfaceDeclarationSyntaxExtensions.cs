using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class InterfaceDeclarationSyntaxExtensions
    {
        public static bool IsPartial(this InterfaceDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }

        public static InterfaceDeclarationSyntax IsPartial(this InterfaceDeclarationSyntax syntax, bool isPartial)
        {
            if (syntax.IsPartial() == isPartial)
            {
                return syntax;
            }

            if (isPartial)
            {
                syntax = syntax.WithModifiers(syntax.Modifiers.Add(SyntaxKind.PartialKeyword));
            }
            else
            {
                syntax = syntax.WithModifiers(syntax.Modifiers.Remove(SyntaxKind.PartialKeyword));
            }

            return syntax;
        }
    }
}
