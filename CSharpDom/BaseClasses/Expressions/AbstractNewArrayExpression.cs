using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewArrayExpression<TTypeReference, TExpression> :
        AbstractExpression,
        INewArrayExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IReadOnlyList<int> Dimensions { get; }

        public abstract TTypeReference ElementType { get; }

        public abstract IReadOnlyList<TExpression> InitialSizeExpressions { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewArrayExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewArrayExpressionChildren(this, visitor);
        }
    }
}
