using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryFromExpression : IQueryFromExpression<Expression>
    {
        public Expression Expression { get; set; }

        public string Identifier { get; set; }
        
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
