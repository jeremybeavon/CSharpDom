using System;
using System.Linq.Expressions;
using LinqBinaryExpression = System.Linq.Expressions.BinaryExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class BinaryExpressionBuilder
    {
        public BinaryExpressionBuilder(
            Func<Expression, Expression, LinqBinaryExpression> linqExpressionBuilder,
            BinaryExpressionType expressionType)
        {
            LinqExpressionBuilder = linqExpressionBuilder;
            ExpressionType = expressionType;
        }

        public Func<Expression, Expression, LinqBinaryExpression> LinqExpressionBuilder { get; private set; }

        public BinaryExpressionType ExpressionType { get; private set; }
    }
}
