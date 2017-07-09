using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QuerySelectIntoExpressionFactory : AbstractExpressionFactory<IQuerySelectIntoExpression, QuerySelectIntoExpression>
    {
        public QuerySelectIntoExpressionFactory(IQuerySelectIntoExpression expression)
            : base(expression)
        {
        }

        public override void VisitQuerySelectIntoExpression<TExpression, TIdentifierExpression>(IQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectIntoExpression)
        {
            Value = new QuerySelectIntoExpression()
            {
                Expression = new ExpressionFactory(querySelectIntoExpression.Expression).Value,
                IntoExpression = new IdentifierExpressionFactory(querySelectIntoExpression.IntoExpression).Value
            };
        }
    }
}
