﻿namespace CSharpDom.Common
{
    public interface IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IClassIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IClassAccessor
    {
    }
}