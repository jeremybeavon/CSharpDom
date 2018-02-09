using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableNamedAttributeValue<TExpression> :
        EditableVisitableObject,
        IEditableNamedAttributeValue<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract string Name { get; set; }

        public abstract TExpression Value { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
        }
    }
}
