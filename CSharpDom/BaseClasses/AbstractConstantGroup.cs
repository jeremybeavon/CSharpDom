using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyCollection<TConstant> Constants { get; }

        public abstract TTypeReference FieldType { get; }
        
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstantGroup(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstantGroupChildren(this, visitor);
        }
    }
}
