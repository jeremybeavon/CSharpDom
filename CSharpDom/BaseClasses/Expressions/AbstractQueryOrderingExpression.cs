using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryOrderingExpression<TExpression> : IQueryOrderingExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract QueryOrderByType OrderByType { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderingExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderingExpressionChildren(this, visitor);
        }
    }
}
