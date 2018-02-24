using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractArrayIndexExpression<TExpression, TArgument> :
        AbstractExpression,
        IArrayIndexExpression<TExpression, TArgument>
        where TExpression : IExpression
        where TArgument : IArgument
    {
        public abstract TExpression Array { get; }

        public abstract IReadOnlyList<TArgument> Indexes { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArrayIndexExpressionChildren(this, visitor);
        }
    }
}
