using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructField<TAttributeGroup, TDeclaringType, TTypeReference> :
        AbstractField<TAttributeGroup, TDeclaringType, TTypeReference>,
        IStructField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructField(this);
        }
    }
}
