using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QuerySelectIntoExpression : IQuerySelectIntoExpression<Expression, IdentifierExpression>
    {
        public Expression Expression { get; set; }

        public IdentifierExpression IntoExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectIntoExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectIntoExpressionChildren(this, visitor);
        }
    }
}
