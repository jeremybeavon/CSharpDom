using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractMethodCallExpression<TExpression> : 
        AbstractExpression,
        IMethodCallExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract IReadOnlyList<TExpression> ParameterExpressions { get; }

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
