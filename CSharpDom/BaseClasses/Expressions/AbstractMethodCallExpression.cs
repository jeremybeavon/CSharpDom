using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractMethodCallExpression<TExpression, TTypeReference, TArgument> : 
        AbstractExpression,
        IMethodCallExpression<TExpression, TTypeReference, TArgument>
        where TExpression : IExpression
        where TTypeReference : ITypeReference
        where TArgument : IArgument
    {
        public abstract TExpression Expression { get; }
        
        public abstract IReadOnlyList<TArgument> Parameters { get; }

        public abstract IReadOnlyList<TTypeReference> GenericParameters { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }
    }
}
