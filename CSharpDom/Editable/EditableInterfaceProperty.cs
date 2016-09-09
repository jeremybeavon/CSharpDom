using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TTypeReference : ITypeReference
        where TAccessor : IInterfaceAccessor
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfacePropertyChildren(this, visitor);
        }
    }
}
