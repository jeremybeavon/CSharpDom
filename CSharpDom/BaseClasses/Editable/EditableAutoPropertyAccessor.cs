using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAutoPropertyAccessor<TAttributeGroup> :
        EditableAccessor<TAttributeGroup>,
        IEditableAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAutoPropertyAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAutoPropertyAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
