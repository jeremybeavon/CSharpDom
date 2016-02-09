using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryFromExpressionFactory : AbstractExpressionFactory<IQueryFromExpression, QueryFromExpression>
    {
        public QueryFromExpressionFactory(IQueryFromExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression>(
            IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression> queryFromExpression)
        {
            Value = new QueryFromExpression()
            {
                Expression = new ExpressionFactory(queryFromExpression.Expression).Value,
                Identifier = new IdentifierExpressionFactory(queryFromExpression.Identifier).Value,
                QueryExpressions = queryFromExpression.QueryExpressions.ToList(expression => new QueryExpressionFactory(expression).Value)
            };
        }
    }
}
