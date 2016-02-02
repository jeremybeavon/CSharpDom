namespace CSharpDom.Common
{
    public interface IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IInterfaceEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
    }
}
