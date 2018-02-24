using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableRefArgument<TExpression> :
        EditableArgument<TExpression>,
        IEditableRefArgument<TExpression>
        where TExpression : IEditableExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRefArgument(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitRefArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitRefArgumentChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
