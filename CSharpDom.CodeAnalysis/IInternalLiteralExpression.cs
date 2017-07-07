using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IInternalLiteralExpression : IHasSyntax<LiteralExpressionSyntax>, IInternalExpression
    {
    }
}
