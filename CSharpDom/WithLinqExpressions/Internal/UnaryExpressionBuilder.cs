using System;
using System.Linq.Expressions;
using LinqUnaryExpression = System.Linq.Expressions.UnaryExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class UnaryExpressionBuilder
    {
        public UnaryExpressionBuilder(
            Func<Expression, LinqUnaryExpression> linqExpressionBuilder,
            UnaryExpressionType expressionType)
        {
            LinqExpressionBuilder = linqExpressionBuilder;
            ExpressionType = expressionType;
        }

        public Func<Expression, LinqUnaryExpression> LinqExpressionBuilder { get; private set; }

        public UnaryExpressionType ExpressionType { get; private set; }
    }
}
