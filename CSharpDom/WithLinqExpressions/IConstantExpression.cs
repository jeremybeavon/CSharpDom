using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IConstantExpression : ILinqExpressionMapping<ConstantExpression, LiteralExpressionSyntax>
    {
    }
}
