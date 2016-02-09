using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryJoinExpressionFactory : AbstractExpressionFactory<IQueryJoinExpression, QueryJoinExpression>
    {
        public QueryJoinExpressionFactory(IQueryJoinExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryJoinExpression<TExpression, TIdentifierExpresion>(IQueryJoinExpression<TExpression, TIdentifierExpresion> queryJoinExpression)
        {
            Value = new QueryJoinExpression()
            {
                EqualsExpression = new ExpressionFactory(queryJoinExpression.EqualsExpression).Value,
                InExpression = new ExpressionFactory(queryJoinExpression.InExpression).Value,
                IntoExpression = new IdentifierExpressionFactory(queryJoinExpression.IntoExpression).Value,
                JoinExpression = new IdentifierExpressionFactory(queryJoinExpression.JoinExpression).Value,
                OnExpression = new ExpressionFactory(queryJoinExpression.OnExpression).Value
            };            
        }
    }
}
