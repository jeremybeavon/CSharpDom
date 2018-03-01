using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IEditableInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableInterfaceType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableInterfaceAccessor
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
