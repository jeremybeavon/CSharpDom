﻿namespace CSharpDom.Common
{
    public interface IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IAbstractProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IAbstractType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
    }
}
