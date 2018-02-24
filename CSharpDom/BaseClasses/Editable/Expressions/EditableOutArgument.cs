using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableOutArgument<TExpression> : 
        EditableArgument<TExpression>,
        IEditableOutArgument<TExpression>
        where TExpression : IEditableExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutArgument(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitOutArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutArgumentChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
