using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryExpressionFactory : AbstractExpressionFactory<IQueryExpression, QueryExpression>
    {
        public QueryExpressionFactory(IQueryExpression expression)
            : base(expression)
        {
        }
    }
}
