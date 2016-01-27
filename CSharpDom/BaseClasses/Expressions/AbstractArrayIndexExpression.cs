using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractArrayIndexExpression<TExpression> : IArrayIndexExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Array { get; }

        public abstract IReadOnlyList<TExpression> Indexes { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArrayIndexExpressionChildren(this, visitor);
        }
    }
}
