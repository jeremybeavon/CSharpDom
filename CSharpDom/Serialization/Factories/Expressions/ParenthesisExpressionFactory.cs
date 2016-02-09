using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ParenthesisExpressionFactory : AbstractExpressionFactory<IParenthesisExpression, ParenthesisExpression>
    {
        public ParenthesisExpressionFactory(IParenthesisExpression expression)
            : base(expression)
        {
        }

        public override void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
        {
            Value = new ParenthesisExpression()
            {
                Expression = new ExpressionFactory(parenthesisExpression.Expression).Value
            };
        }
    }
}
