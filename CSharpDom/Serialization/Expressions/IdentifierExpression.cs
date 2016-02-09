using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class IdentifierExpression : IIdentifierExpression
    {
        public string Name { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
