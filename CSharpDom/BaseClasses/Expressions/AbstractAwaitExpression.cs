using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractAwaitExpression<TExpression> : AbstractExpression, IAwaitExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAwaitExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitAwaitExpressionChildren(this, visitor);
        }
    }
}
