using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyCollection<TField> Fields { get; }

        public abstract TTypeReference FieldType { get; }

        public abstract string Name { get; }

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
