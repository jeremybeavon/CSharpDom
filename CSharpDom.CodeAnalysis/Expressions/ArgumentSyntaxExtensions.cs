using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal static class ArgumentSyntaxExtensions
    {
        public static IInternalArgument ToInternalArgument(this ArgumentSyntax syntax)
        {
            switch (syntax.RefOrOutKeyword.Kind())
            {
                case SyntaxKind.OutKeyword:
                    return new OutExpressionWithCodeAnalysis();
                case SyntaxKind.RefKeyword:
                    return new RefExpressionWithCodeAnalysis();
                default:
                    return new ArgumentExpressionWithCodeAnalysis();
            }
        }
    }
}
