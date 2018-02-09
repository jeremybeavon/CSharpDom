using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableExpression : AbstractExpression, IEditableExpression
    {
        public abstract void Accept(IEditableExpressionVisitor visitor);

        public abstract void AcceptChildren(IEditableExpressionVisitor visitor);
    }
}
