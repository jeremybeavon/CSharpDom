using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryOrderByExpression<TOrderingExpression> :
        IQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IQueryOrderingExpression
    {
        public abstract IList<TOrderingExpression> Orders { get; set; }

        IReadOnlyList<TOrderingExpression> IQueryOrderByExpression<TOrderingExpression>.Orders
        {
            get { return new ReadOnlyCollection<TOrderingExpression>(Orders); }
        }

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
