using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticClassAutoPropertyAccessor<TAttributeGroup> :
        EditableAutoPropertyAccessor<TAttributeGroup>,
        IEditableStaticClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public abstract StaticClassAccessorVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAutoPropertyAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            base.Accept(visitor);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassAutoPropertyAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            base.AcceptChildren(visitor);
        }
    }
}
