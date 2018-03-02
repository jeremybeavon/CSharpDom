using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructAutoPropertyAccessor<TAttributeGroup> :
        EditableAutoPropertyAccessor<TAttributeGroup>,
        IEditableStructAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public abstract StructAccessorVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructAutoPropertyAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            base.Accept(visitor);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructAutoPropertyAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            base.AcceptChildren(visitor);
        }
    }
}
