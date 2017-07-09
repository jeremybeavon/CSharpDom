using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryGroupIntoExpressionFactory : AbstractExpressionFactory<IQueryGroupIntoExpression, QueryGroupIntoExpression>
    {
        public QueryGroupIntoExpressionFactory(IQueryGroupIntoExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryGroupIntoExpression<TExpression, TIdentiferExpression>(
            IQueryGroupIntoExpression<TExpression, TIdentiferExpression> queryGroupExpression)
        {
            Value = new QueryGroupIntoExpression()
            {
                ByExpression = new ExpressionFactory(queryGroupExpression.ByExpression).Value,
                GroupExpression = new ExpressionFactory(queryGroupExpression.GroupExpression).Value,
                IntoExpression = new IdentifierExpressionFactory(queryGroupExpression.IntoExpression).Value
            };
        }
    }
}
