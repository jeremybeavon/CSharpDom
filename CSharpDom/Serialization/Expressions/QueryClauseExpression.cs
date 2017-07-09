using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryClauseExpression : IQueryClauseExpression
    {
        [DefaultValue(null)]
        public QueryFromExpression QueryFromExpression { get; set; }

        [DefaultValue(null)]
        public QueryGroupIntoExpression QueryGroupIntoExpression { get; set; }

        [DefaultValue(null)]
        public QueryJoinExpression QueryJoinExpression { get; set; }

        [DefaultValue(null)]
        public QueryLetExpression QueryLetExpression { get; set; }

        [DefaultValue(null)]
        public QueryOrderByExpression QueryOrderByExpression { get; set; }

        [DefaultValue(null)]
        public QuerySelectIntoExpression QuerySelectIntoExpression { get; set; }

        [DefaultValue(null)]
        public QueryWhereExpression QueryWhereExpression { get; set; }

        private IEnumerable<IQueryClauseExpression> QueryExpressions
        {
            get
            {
                yield return QueryFromExpression;
                yield return QueryGroupIntoExpression;
                yield return QueryJoinExpression;
                yield return QueryLetExpression;
                yield return QueryOrderByExpression;
                yield return QuerySelectIntoExpression;
                yield return QueryWhereExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IQueryClauseExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IQueryClauseExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.AcceptChildren(visitor);
            }
        }
    }
}
