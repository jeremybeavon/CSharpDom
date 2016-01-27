using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractTernaryOperatorExpression<TExpression> : ITernaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Left { get; }

        public abstract TExpression Middle { get; }

        public abstract TExpression Right { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTernaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitTernaryOperatorExpressionChildren(this, visitor);
        }
    }
}
