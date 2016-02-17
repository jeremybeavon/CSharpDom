namespace CSharpDom.Common
{
    public interface ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        ISealedClassEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasFieldAttributes<TAttributeGroup>,
        IHasSealedClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
    }
}
