using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryExpression : IQueryExpression
    {
        [DefaultValue(null)]
        public QueryFromExpression QueryFromExpression { get; set; }

        [DefaultValue(null)]
        public QueryGroupExpression QueryGroupExpression { get; set; }

        [DefaultValue(null)]
        public QueryJoinExpression QueryJoinExpression { get; set; }

        [DefaultValue(null)]
        public QueryLetExpression QueryLetExpression { get; set; }

        [DefaultValue(null)]
        public QueryOrderByExpression QueryOrderByExpression { get; set; }

        [DefaultValue(null)]
        public QuerySelectExpression QuerySelectExpression { get; set; }

        [DefaultValue(null)]
        public QueryWhereExpression QueryWhereExpression { get; set; }

        private IEnumerable<IQueryExpression> QueryExpressions
        {
            get
            {
                yield return QueryFromExpression;
                yield return QueryGroupExpression;
                yield return QueryJoinExpression;
                yield return QueryLetExpression;
                yield return QueryOrderByExpression;
                yield return QuerySelectExpression;
                yield return QueryWhereExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IQueryExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IQueryExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.AcceptChildren(visitor);
            }
        }
    }
}
