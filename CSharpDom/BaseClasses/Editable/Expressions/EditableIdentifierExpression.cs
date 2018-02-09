using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableIdentifierExpression : EditableExpression, IEditableIdentifierExpression
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
