using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQuerySelectExpression<TExpression> : IQuerySelectExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public virtual void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectExpression(this);
        }

        public virtual void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectExpressionChildren(this, visitor);
        }
    }
}
