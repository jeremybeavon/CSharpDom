using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableUnnamedAttributeValue<TExpression> :
        EditableVisitableObject,
        IEditableUnnamedAttributeValue<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Value { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
        }
    }
}
