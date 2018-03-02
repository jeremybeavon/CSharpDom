using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassAutoPropertyAccessor<TAttributeGroup> :
        EditableAutoPropertyAccessor<TAttributeGroup>,
        IEditableClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public abstract ClassAccessorVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAutoPropertyAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassAutoPropertyAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
