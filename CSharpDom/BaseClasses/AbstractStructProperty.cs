using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IStructAccessor
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructProperty(this);
        }
    }
}
