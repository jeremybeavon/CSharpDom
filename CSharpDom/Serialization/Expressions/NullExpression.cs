using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class NullExpression : INullExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
