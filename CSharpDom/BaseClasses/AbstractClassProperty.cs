using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassProperty(this);
        }
    }
}
