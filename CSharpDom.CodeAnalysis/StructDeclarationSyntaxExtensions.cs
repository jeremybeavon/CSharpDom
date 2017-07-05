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
    }
}
