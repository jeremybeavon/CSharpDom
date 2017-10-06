using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryOrderByExpression<TOrderingExpression> :
        AbstractExpression,
        IQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IQueryOrderingExpression
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

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }
    }
}
