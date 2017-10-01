using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractOutExpression<TExpression> : AbstractExpression, IOutExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutExpressionChildren(this, visitor);
        }
    }
}
