using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class UnaryOperatorExpression : IUnaryOperatorExpression<Expression>
    {
        public Expression Operand { get; set; }

        public UnaryOperatorExpressionType OperatorType { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitUnaryOperatorExpressionChildren(this, visitor);
        }
    }
}
