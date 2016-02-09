using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryGroupExpressionFactory : AbstractExpressionFactory<IQueryGroupExpression, QueryGroupExpression>
    {
        public QueryGroupExpressionFactory(IQueryGroupExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryGroupExpression<TExpression, TIdentiferExpression>(IQueryGroupExpression<TExpression, TIdentiferExpression> queryGroupExpression)
        {
            Value = new QueryGroupExpression()
            {
                ByExpression = new ExpressionFactory(queryGroupExpression.ByExpression).Value,
                GroupExpression = new ExpressionFactory(queryGroupExpression.GroupExpression).Value,
                IntoExpression = new IdentifierExpressionFactory(queryGroupExpression.IntoExpression).Value
            };
        }
    }
}
