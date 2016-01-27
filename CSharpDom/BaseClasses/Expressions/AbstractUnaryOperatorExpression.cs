using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractUnaryOperatorExpression<TExpression> : IUnaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Operand { get; }

        public abstract UnaryOperatorExpressionType OperatorType { get; }

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
