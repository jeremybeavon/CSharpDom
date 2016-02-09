using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class IntegerConstantExpression : IIntegerConstantExpression
    {
        public int Constant { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIntegerConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
