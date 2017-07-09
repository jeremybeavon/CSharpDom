using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> :
        IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>
        where TQueryFromExpression : IQueryFromExpression
        where TQueryClauseExpression : IQueryClauseExpression
        where TQueryEndExpression : IQueryEndExpression
    {
        public abstract TQueryFromExpression StartExpression { get; set; }

        public abstract IList<TQueryClauseExpression> Expressions { get; set; }

        public abstract TQueryEndExpression EndExpression { get; set; }

        IReadOnlyList<TQueryClauseExpression> IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>.Expressions
        {
            get { return new ReadOnlyCollection<TQueryClauseExpression>(Expressions); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryExpressionChildren(this, visitor);
        }
    }
}
