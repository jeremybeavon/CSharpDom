using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class RefExpressionFactory : AbstractExpressionFactory<IRefExpression, RefExpression>
    {
        public RefExpressionFactory(IRefExpression expression)
            : base(expression)
        {
        }

        public override void VisitRefExpression<TExpression>(IRefExpression<TExpression> refExpression)
        {
            Value = new RefExpression()
            {
                Expression = new ExpressionFactory(refExpression.Expression).Value
            };
        }
    }
}
