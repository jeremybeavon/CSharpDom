using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableIntegerConstantExpression : EditableExpression, IEditableIntegerConstantExpression
    {
        public abstract int Constant { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIntegerConstantExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitIntegerConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
