using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryOrderByExpression : IQueryOrderByExpression<QueryOrderingExpression>
    {
        public QueryOrderByExpression()
        {
            Orders = new List<QueryOrderingExpression>();
        }

        public List<QueryOrderingExpression> Orders { get; set; }

        IReadOnlyList<QueryOrderingExpression> IQueryOrderByExpression<QueryOrderingExpression>.Orders => Orders;

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }
    }
}
