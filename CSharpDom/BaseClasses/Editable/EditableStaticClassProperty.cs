using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TAccessor : IStaticClassAccessor
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassPropertyChildren(this, visitor);
        }
    }
}
