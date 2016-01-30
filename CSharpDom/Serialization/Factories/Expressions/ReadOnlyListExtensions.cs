using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public static class ReadOnlyListExtensions
    {
        public static List<Expression> ToExpressionListUsingFactory<TExpression>(
            this IReadOnlyCollection<TExpression> expressions)
            where TExpression : IExpression
        {
            return expressions.ToList(expression => new ExpressionFactory(expression).Value);
        }
    }
}
