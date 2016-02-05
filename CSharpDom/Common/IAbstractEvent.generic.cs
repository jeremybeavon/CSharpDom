namespace CSharpDom.Common
{
    public interface IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IAbstractEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IAbstractType
        where TDelegateReference : IDelegateReference
    {
    }
}
