using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryOrderByExpressionFactory : AbstractExpressionFactory<IQueryOrderByExpression, QueryOrderByExpression>
    {
        public QueryOrderByExpressionFactory(IQueryOrderByExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryOrderByExpression<TExpression>(IQueryOrderByExpression<TExpression> queryOrderByExpression)
        {
            Value = new QueryOrderByExpression()
            {
                Expression = new ExpressionFactory(queryOrderByExpression.Expression).Value,
                OrderByType = queryOrderByExpression.OrderByType
            };
        }
    }
}
