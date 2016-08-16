using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public virtual StructFieldModifier Modifier { get; set; }

        public virtual StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructFieldChildren(this, visitor);
        }
    }
}
