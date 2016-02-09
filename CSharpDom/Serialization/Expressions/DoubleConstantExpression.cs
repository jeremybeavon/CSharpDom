using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class DoubleConstantExpression : IDoubleConstantExpression
    {
        public double Constant { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
