using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractCastExpression<TTypeReference, TExpression> :
        AbstractExpression,
        ICastExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract TTypeReference Type { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitCastExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitCastExpressionChildren(this, visitor);
        }
    }
}
