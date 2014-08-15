using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IUnaryExpression : ILinqExpressionMapping<UnaryExpression, PrefixUnaryExpressionSyntax>
    {
        ILinqExpressionMapping Operand { get; }

        UnaryExpressionType ExpressionType { get; }
    }
}
