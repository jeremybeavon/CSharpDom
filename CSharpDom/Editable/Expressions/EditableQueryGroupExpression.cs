using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryGroupExpression<TExpression> :
        IQueryGroupExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ByExpression { get; set; }

        public abstract TExpression GroupExpression { get; set; }
        
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
