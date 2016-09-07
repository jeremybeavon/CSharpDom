using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class ConstructorDeclarationSyntaxExtensions
    {
        public static bool IsStatic(this ConstructorDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.StaticKeyword);
        }
    }
}
