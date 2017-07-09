using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryGroupExpression<TExpression> :
        IQueryGroupExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ByExpression { get; }

        public abstract TExpression GroupExpression { get; }

        public virtual void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupExpression(this);
        }

        public virtual void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupExpressionChildren(this, visitor);
        }
    }
}
