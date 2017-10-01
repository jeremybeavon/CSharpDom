using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractUnaryOperatorExpression<TExpression> :
        AbstractExpression,
        IUnaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Operand { get; }

        public abstract UnaryOperatorExpressionType OperatorType { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitUnaryOperatorExpressionChildren(this, visitor);
        }
    }
}
