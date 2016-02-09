using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class AwaitExpression : IAwaitExpression<Expression>
    {
        public Expression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAwaitExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitAwaitExpressionChildren(this, visitor);
        }
    }
}
