using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal static class MethodDeclarationSyntaxExtensions
    {
        internal static bool IsPartial(this MethodDeclarationSyntax syntax)
        {
            return syntax.Modifiers.Any(SyntaxKind.PartialKeyword);
        }
    }
}
