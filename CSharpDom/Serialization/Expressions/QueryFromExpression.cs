using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryFromExpression : IQueryFromExpression<IdentifierExpression, Expression, QueryExpression>
    {
        public QueryFromExpression()
        {
            QueryExpressions = new List<QueryExpression>();
        }

        public Expression Expression { get; set; }

        public IdentifierExpression Identifier { get; set; }

        public List<QueryExpression> QueryExpressions { get; set; }

        IReadOnlyList<QueryExpression> IQueryFromExpression<IdentifierExpression, Expression, QueryExpression>.QueryExpressions
        {
            get { return QueryExpressions; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryFromExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryFromExpressionChildren(this, visitor);
        }
    }
}
