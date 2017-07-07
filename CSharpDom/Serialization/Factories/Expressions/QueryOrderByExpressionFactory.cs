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

        public override void VisitQueryOrderByExpression<TOrderingExpression>(
            IQueryOrderByExpression<TOrderingExpression> queryOrderByExpression)
        {
            Value = new QueryOrderByExpression()
            {
                Orders = queryOrderByExpression.Orders.ToList(order => new QueryOrderingExpressionFactory(order).Value)
            };
        }
    }
}
