using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference>,
        IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
    {
        public abstract bool HasGet { get; }

        public abstract bool HasSet { get; }

        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceProperty(this);
        }
    }
}
