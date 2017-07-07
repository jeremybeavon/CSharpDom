using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryOrderingExpressionFactory : AbstractExpressionFactory<IQueryOrderingExpression, QueryOrderingExpression>
    {
        public QueryOrderingExpressionFactory(IQueryOrderingExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryOrderingExpression<TExpression>(IQueryOrderingExpression<TExpression> queryOrderingExpression)
        {
            Value = new QueryOrderingExpression()
            {
                Expression = new ExpressionFactory(queryOrderingExpression.Expression).Value,
                OrderByType = queryOrderingExpression.OrderByType
            };
        }
    }
}
