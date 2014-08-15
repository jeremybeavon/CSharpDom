using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IBinaryExpression : ILinqExpressionMapping<BinaryExpression, BinaryExpressionSyntax>
    {
        ILinqExpressionMapping Left { get; }

        ILinqExpressionMapping Right { get; }

        BinaryExpressionType ExpressionType { get; }
    }
}
