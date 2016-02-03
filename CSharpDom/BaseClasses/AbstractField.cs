using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TTypeReference FieldType { get; }

        public abstract FieldModifier Modifier { get; }

        public abstract string Name { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitFieldChildren(this, visitor);
        }
    }
}
