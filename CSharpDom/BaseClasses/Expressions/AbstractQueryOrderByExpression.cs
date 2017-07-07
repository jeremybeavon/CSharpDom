using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryOrderByExpression<TOrderingExpression> :
        IQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IQueryOrderingExpression
    {
        public abstract IReadOnlyList<TOrderingExpression> Orders { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }
    }
}
