using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableNullExpression : EditableExpression, IEditableNullExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
