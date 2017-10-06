using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterfaceAccessor<TAttributeGroup> :
        EditableAccessor<TAttributeGroup>,
        IInterfaceAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceAccessorChildren(this, visitor);
        }
    }
}
