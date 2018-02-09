using System;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterfaceAccessor<TAttributeGroup> :
        EditableAccessor<TAttributeGroup>,
        IEditableInterfaceAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitInterfaceAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
