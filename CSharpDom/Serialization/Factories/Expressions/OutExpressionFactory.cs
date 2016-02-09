using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class OutExpressionFactory : AbstractExpressionFactory<IOutExpression, OutExpression>
    {
        public OutExpressionFactory(IOutExpression expression)
            : base(expression)
        {
        }

        public override void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
        {
            Value = new OutExpression()
            {
                Expression = new ExpressionFactory(outExpression.Expression).Value
            };
        }
    }
}
