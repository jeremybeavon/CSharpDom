using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IReadOnlyCollection<TField> Fields { get; set; }

        public virtual TTypeReference FieldType { get; set; }
        
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitFieldGroup(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitFieldGroupChildren(this, visitor);
        }
    }
}
