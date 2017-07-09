using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryGroupIntoExpression : IQueryGroupIntoExpression<Expression, IdentifierExpression>
    {
        public Expression ByExpression { get; set; }

        public Expression GroupExpression { get; set; }

        public IdentifierExpression IntoExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupIntoExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupIntoExpressionChildren(this, visitor);
        }
    }
}
