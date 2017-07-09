using CSharpDom.Common.Expressions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryExpression : IQueryExpression<QueryFromExpression, QueryClauseExpression, QueryEndExpression>
    {
        public QueryExpression()
        {
            Expressions = new List<QueryClauseExpression>();
        }

        public QueryFromExpression StartExpression { get; set; }

        public List<QueryClauseExpression> Expressions { get; set; }

        public QueryEndExpression EndExpression { get; set; }

        IReadOnlyList<QueryClauseExpression> IQueryExpression<QueryFromExpression, QueryClauseExpression, QueryEndExpression>.Expressions
        {
            get { return new ReadOnlyCollection<QueryClauseExpression>(Expressions); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryExpressionChildren(this, visitor);
        }
    }
}
