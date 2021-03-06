﻿namespace CSharpDom.Common
{
    public interface IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IStructProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasStructMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TAccessor : IStructAccessor
    {
    }
}
