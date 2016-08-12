using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceAccessor<TAttributeGroup> :
        AbstractAccessor<TAttributeGroup>,
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
