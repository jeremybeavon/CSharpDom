using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQuerySelectIntoExpression<TExpression, TIdentifierExpression> :
        EditableQuerySelectExpression<TExpression>,
        IEditableQuerySelectIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IEditableExpression
        where TIdentifierExpression : IEditableIdentifierExpression
    {
        public abstract TIdentifierExpression IntoExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectIntoExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectIntoExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectIntoExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
