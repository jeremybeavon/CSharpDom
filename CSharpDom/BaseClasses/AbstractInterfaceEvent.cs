using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceEvent(this);
        }
    }
}
