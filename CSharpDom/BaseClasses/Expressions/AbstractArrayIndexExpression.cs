using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractArrayIndexExpression<TExpression> :
        AbstractExpression,
        IArrayIndexExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Array { get; }

        public abstract IReadOnlyList<TExpression> Indexes { get; }

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
