using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractBinaryOperatorExpression<TExpression> :
        AbstractExpression,
        IBinaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Left { get; }

        public abstract BinaryOperatorExpressionType OperatorType { get; }

        public abstract TExpression Right { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
        }
    }
}
