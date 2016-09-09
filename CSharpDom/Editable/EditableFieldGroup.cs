using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract ICollection<TField> Fields { get; set; }

        public abstract TTypeReference FieldType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TField> IHasFields<TField>.Fields
        {
            get { return new ReadOnlyCollectionWrapper<TField>(Fields); }
        }

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
