using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableExplicitInterfaceProperty<
        TAttributeGroup,
        TDeclaringType,
        TInterfaceReference,
        TTypeReference,
        TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
        public abstract TInterfaceReference ExplicitInterface { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExplicitInterfacePropertyChildren(this, visitor);
        }
    }
}
