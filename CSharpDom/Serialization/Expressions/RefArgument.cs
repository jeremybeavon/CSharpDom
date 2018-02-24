using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class RefArgument : IRefArgument<Expression>
    {
        public Expression Expression { get; set; }

        public string Name { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRefArgument(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitRefArgumentChildren(this, visitor);
        }
    }
}
