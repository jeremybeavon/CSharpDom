using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class BinaryOperatorExpression : IBinaryOperatorExpression<Expression>
    {
        public Expression Left { get; set; }

        public BinaryOperatorExpressionType OperatorType { get; set; }

        public Expression Right { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
        }
    }
}
