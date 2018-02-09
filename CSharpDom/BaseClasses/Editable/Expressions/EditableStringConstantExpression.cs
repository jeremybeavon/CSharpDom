using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableStringConstantExpression : EditableExpression, IEditableStringConstantExpression
    {
        public abstract string Constant { get; set; }

        public abstract bool HasAtSymbol { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
