using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class UnaryOperatorExpressionFactory : AbstractExpressionFactory<IUnaryOperatorExpression, UnaryOperatorExpression>
    {
        public UnaryOperatorExpressionFactory(IUnaryOperatorExpression expression)
            : base(expression)
        {
        }

        public override void VisitUnaryOperatorExpression<TExpression>(IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
        {
            Value = new UnaryOperatorExpression()
            {
                Operand = new ExpressionFactory(unaryOperatorExpression.Operand).Value,
                OperatorType = unaryOperatorExpression.OperatorType
            };
        }
    }
}
