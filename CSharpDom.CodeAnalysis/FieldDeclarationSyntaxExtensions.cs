using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class FieldDeclarationSyntaxExtensions
    {
        public static bool IsConstant(this FieldDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.ConstKeyword);
        }
    }
}
