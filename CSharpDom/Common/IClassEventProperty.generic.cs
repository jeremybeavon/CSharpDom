﻿namespace CSharpDom.Common
{
    public interface IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IClassEventProperty,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
