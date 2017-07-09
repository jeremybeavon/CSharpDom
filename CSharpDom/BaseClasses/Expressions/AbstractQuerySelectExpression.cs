using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQuerySelectExpression<TExpression> : IQuerySelectExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public virtual void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectExpression(this);
        }

        public virtual void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectExpressionChildren(this, visitor);
        }
    }
}
