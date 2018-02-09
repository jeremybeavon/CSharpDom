using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableUnaryOperatorExpression<TExpression> :
        EditableExpression,
        IEditableUnaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Operand { get; set; }

        public abstract UnaryOperatorExpressionType OperatorType { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitUnaryOperatorExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
