namespace CSharpDom.Common
{
    public interface IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEvent,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasFieldAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
    }
}
