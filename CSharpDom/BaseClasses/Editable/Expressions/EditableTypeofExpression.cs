using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableTypeofExpression<TTypeReference> :
        EditableExpression,
        IEditableTypeofExpression<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        public abstract TTypeReference Type { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTypeofExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitTypeofExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
