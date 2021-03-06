﻿using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> :
        EditableExpression,
        IEditableQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>
        where TQueryFromExpression : IEditableQueryFromExpression
        where TQueryClauseExpression : IEditableQueryClauseExpression
        where TQueryEndExpression : IEditableQueryEndExpression
    {
        public abstract TQueryFromExpression StartExpression { get; set; }

        public abstract IList<TQueryClauseExpression> Expressions { get; set; }

        public abstract TQueryEndExpression EndExpression { get; set; }

        IReadOnlyList<TQueryClauseExpression> IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>.Expressions
        {
            get { return new ReadOnlyCollection<TQueryClauseExpression>(Expressions); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitQueryExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
