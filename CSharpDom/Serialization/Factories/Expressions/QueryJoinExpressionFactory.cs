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

        public override void VisitQueryJoinExpression<TExpression>(IQueryJoinExpression<TExpression> queryJoinExpression)
        {
            Value = new QueryJoinExpression()
            {
                EqualsExpression = new ExpressionFactory(queryJoinExpression.EqualsExpression).Value,
                InExpression = new ExpressionFactory(queryJoinExpression.InExpression).Value,
                IntoVariable = queryJoinExpression.IntoVariable,
                JoinVariable = queryJoinExpression.JoinVariable,
                OnExpression = new ExpressionFactory(queryJoinExpression.OnExpression).Value
            };            
        }
    }
}
