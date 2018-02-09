using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryGroupIntoExpression<TExpression, TIdentifierExpression> :
        EditableQueryGroupExpression<TExpression>,
        IEditableQueryGroupIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IEditableExpression
        where TIdentifierExpression : IEditableIdentifierExpression
    {
        public abstract TIdentifierExpression IntoExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupIntoExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupIntoExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupIntoExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            base.AcceptChildren(visitor);
        }
    }
}
