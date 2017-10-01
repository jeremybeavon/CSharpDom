using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewExpression<TTypeReference, TExpression> :
        AbstractExpression,
        INewExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IReadOnlyList<TExpression> Parameters { get; }

        public abstract TTypeReference Type { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }
    }
}
