using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryOrderingExpression<TExpression> :
        AbstractExpression,
        IQueryOrderingExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract QueryOrderByType OrderByType { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderingExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderingExpressionChildren(this, visitor);
        }
    }
}
