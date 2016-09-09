using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TDelegateReference : IDelegateReference
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceEventChildren(this, visitor);
        }
    }
}
