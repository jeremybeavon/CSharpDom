using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractMethodCallExpression<TExpression, TArgument> : 
        AbstractExpression,
        IMethodCallExpression<TExpression, TArgument>
        where TExpression : IExpression
        where TArgument : IArgument
    {
        public abstract TExpression Expression { get; }
        
        public abstract IReadOnlyList<TArgument> Parameters { get; }

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
