using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableTernaryOperatorExpression<TExpression> :
        EditableExpression,
        IEditableTernaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Left { get; set; }

        public abstract TExpression Middle { get; set; }

        public abstract TExpression Right { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTernaryOperatorExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitTernaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitTernaryOperatorExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
