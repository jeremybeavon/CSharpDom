using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class MemberExpression : IMemberExpression<Expression>
    {
        public string MemberName { get; set; }

        public Expression ObjectExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMemberExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMemberExpressionChildren(this, visitor);
        }
    }
}
