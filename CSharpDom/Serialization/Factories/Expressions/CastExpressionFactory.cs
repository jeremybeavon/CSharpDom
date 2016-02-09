using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class CastExpressionFactory : AbstractExpressionFactory<ICastExpression, CastExpression>
    {
        public CastExpressionFactory(ICastExpression expression)
            : base(expression)
        {
        }

        public override void VisitCastExpression<TTypeReference, TExpression>(ICastExpression<TTypeReference, TExpression> castExpression)
        {
            Value = new CastExpression()
            {
                Expression = new ExpressionFactory(castExpression.Expression).Value,
                Type = new TypeReferenceFactory(castExpression.Type).Value
            };
        }
    }
}
