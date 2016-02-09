using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryWhereExpressionFactory : AbstractExpressionFactory<IQueryWhereExpression, QueryWhereExpression>
    {
        public QueryWhereExpressionFactory(IQueryWhereExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryWhereExpression<TExpression>(IQueryWhereExpression<TExpression> queryWhereExpression)
        {
            Value = new QueryWhereExpression()
            {
                Expression = new ExpressionFactory(queryWhereExpression.Expression).Value
            };
        }
    }
}
