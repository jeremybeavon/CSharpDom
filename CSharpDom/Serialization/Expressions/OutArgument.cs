using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class OutArgument : IOutArgument<Expression>
    {
        public Expression Expression { get; set; }

        public string Name { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutArgument(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutArgumentChildren(this, visitor);
        }
    }
}
