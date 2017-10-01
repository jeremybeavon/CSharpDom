using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> :
        AbstractExpression,
        IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>
        where TQueryFromExpression : IQueryFromExpression
        where TQueryClauseExpression : IQueryClauseExpression
        where TQueryEndExpression : IQueryEndExpression
    {
        public abstract TQueryFromExpression StartExpression { get; }

        public abstract IReadOnlyList<TQueryClauseExpression> Expressions { get; }

        public abstract TQueryEndExpression EndExpression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryExpressionChildren(this, visitor);
        }
    }
}
