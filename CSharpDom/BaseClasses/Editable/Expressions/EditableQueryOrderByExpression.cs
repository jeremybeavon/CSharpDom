using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryOrderByExpression<TOrderingExpression> :
        EditableExpression,
        IEditableQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IEditableQueryOrderingExpression
    {
        public abstract IList<TOrderingExpression> Orders { get; set; }

        IReadOnlyList<TOrderingExpression> IQueryOrderByExpression<TOrderingExpression>.Orders
        {
            get { return new ReadOnlyCollection<TOrderingExpression>(Orders); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
