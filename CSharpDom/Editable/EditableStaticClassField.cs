using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public abstract StaticClassFieldModifier Modifier { get; set; }

        public abstract StaticClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassFieldChildren(this, visitor);
        }
    }
}
