using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractParenthesisExpression<TExpression> : IParenthesisExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitParenthesisExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitParenthesisExpressionChildren(this, visitor);
        }
    }
}
