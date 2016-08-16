using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public virtual ClassFieldModifier Modifier { get; set; }

        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassFieldChildren(this, visitor);
        }
    }
}
