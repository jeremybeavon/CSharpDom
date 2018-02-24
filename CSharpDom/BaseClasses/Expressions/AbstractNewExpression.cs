using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewExpression<TTypeReference, TArgument> :
        AbstractExpression,
        INewExpression<TTypeReference, TArgument>
        where TTypeReference : ITypeReference
        where TArgument : IArgument
    {
        public abstract IReadOnlyList<TArgument> Parameters { get; }

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
