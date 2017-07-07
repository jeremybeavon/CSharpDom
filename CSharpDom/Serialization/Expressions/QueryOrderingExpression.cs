using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryOrderingExpression : IQueryOrderingExpression<Expression>
    {
        public Expression Expression { get; set; }

        public QueryOrderByType OrderByType { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderingExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderingExpressionChildren(this, visitor);
        }
    }
}
