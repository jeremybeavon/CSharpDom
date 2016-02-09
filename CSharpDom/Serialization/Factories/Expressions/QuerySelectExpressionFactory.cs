using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QuerySelectExpressionFactory : AbstractExpressionFactory<IQuerySelectExpression, QuerySelectExpression>
    {
        public QuerySelectExpressionFactory(IQuerySelectExpression expression)
            : base(expression)
        {
        }

        public override void VisitQuerySelectExpression<TExpression>(IQuerySelectExpression<TExpression> querySelectExpression)
        {
            Value = new QuerySelectExpression()
            {
                Expression = new ExpressionFactory(querySelectExpression.Expression).Value
            };
        }
    }
}
