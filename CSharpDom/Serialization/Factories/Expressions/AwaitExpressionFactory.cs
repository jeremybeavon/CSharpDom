using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class AwaitExpressionFactory : AbstractExpressionFactory<IAwaitExpression, AwaitExpression>
    {
        public AwaitExpressionFactory(IAwaitExpression expression)
            : base(expression)
        {
        }

        public override void VisitAwaitExpression<TExpression>(IAwaitExpression<TExpression> awaitExpression)
        {
            Value = new AwaitExpression()
            {
                Expression = new ExpressionFactory(awaitExpression.Expression).Value
            };
        }
    }
}
