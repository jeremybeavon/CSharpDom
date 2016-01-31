using CSharpDom.BaseClasses.Expressions;
using System;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class UnaryOperatorExpressionWithLinqExpressions :
        AbstractUnaryOperatorExpression<ILinqExpression>,
        ILinqExpression<UnaryExpression>
    {
        private readonly ILinqExpression operand;

        public UnaryOperatorExpressionWithLinqExpressions(UnaryExpression expression)
        {
            Expression = expression;
            operand = LinqExpressionBuilder.BuildExpression(expression.Operand);
        }

        public UnaryExpression Expression { get; private set; }

        public override ILinqExpression Operand
        {
            get { return operand; }
        }

        public override UnaryOperatorExpressionType OperatorType
        {
            get
            {
                switch (Expression.NodeType)
                {
                    case ExpressionType.UnaryPlus:
                        return UnaryOperatorExpressionType.Plus;
                    case ExpressionType.Negate:
                        return UnaryOperatorExpressionType.Minus;
                    case ExpressionType.Not:
                        return Expression.Type == typeof(bool) ?
                            UnaryOperatorExpressionType.LogicalNot :
                            UnaryOperatorExpressionType.BitwiseNot;
                    case ExpressionType.PreIncrementAssign:
                        return UnaryOperatorExpressionType.PreIncrement;
                    case ExpressionType.PreDecrementAssign:
                        return UnaryOperatorExpressionType.PreDecrement;
                    case ExpressionType.PostIncrementAssign:
                        return UnaryOperatorExpressionType.PostIncrement;
                    case ExpressionType.PostDecrementAssign:
                        return UnaryOperatorExpressionType.PostDecrement;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
