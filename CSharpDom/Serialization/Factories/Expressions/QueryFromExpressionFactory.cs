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

        public override void VisitQueryFromExpression<TExpression>(
            IQueryFromExpression<TExpression> queryFromExpression)
        {
            Value = new QueryFromExpression()
            {
                Expression = new ExpressionFactory(queryFromExpression.Expression).Value,
                Identifier = queryFromExpression.Identifier
            };
        }
    }
}
