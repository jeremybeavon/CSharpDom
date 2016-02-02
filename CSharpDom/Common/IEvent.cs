namespace CSharpDom.Common
{
    public interface IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
    }
}
