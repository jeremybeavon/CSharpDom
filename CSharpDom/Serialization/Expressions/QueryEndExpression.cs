using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryEndExpression : IQueryEndExpression
    {
        [DefaultValue(null)]
        public QueryGroupExpression QueryGroupExpression { get; set; }
        
        [DefaultValue(null)]
        public QuerySelectExpression QuerySelectExpression { get; set; }
        
        private IEnumerable<IQueryEndExpression> QueryExpressions
        {
            get
            {
                yield return QueryGroupExpression;
                yield return QuerySelectExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IQueryEndExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IQueryEndExpression queryExpressions = QueryExpressions.FirstOrDefault(current => current != null);
            if (queryExpressions != null)
            {
                queryExpressions.AcceptChildren(visitor);
            }
        }
    }
}
