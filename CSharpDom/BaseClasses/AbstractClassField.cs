using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        AbstractField<TAttributeGroup, TDeclaringType, TTypeReference>,
        IClassField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassField(this);
        }
    }
}
