using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryClauseExpressionFactory : AbstractExpressionFactory<IQueryClauseExpression, QueryClauseExpression>
    {
        public QueryClauseExpressionFactory(IQueryClauseExpression expression)
            : base(expression)
        {
        }
    }
}
