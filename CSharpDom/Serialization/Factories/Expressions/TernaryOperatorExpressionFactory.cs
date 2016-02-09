using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class TernaryOperatorExpressionFactory : AbstractExpressionFactory<ITernaryOperatorExpression, TernaryOperatorExpression>
    {
        public TernaryOperatorExpressionFactory(ITernaryOperatorExpression expression)
            : base(expression)
        {
        }

        public override void VisitTernaryOperatorExpression<TExpression>(ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
        {
            Value = new TernaryOperatorExpression()
            {
                Left = new ExpressionFactory(ternaryOperatorExpression.Left).Value,
                Middle = new ExpressionFactory(ternaryOperatorExpression.Middle).Value,
                Right = new ExpressionFactory(ternaryOperatorExpression.Right).Value
            };
        }
    }
}
