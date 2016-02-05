namespace CSharpDom.Common
{
    public interface IProtectedOverrideEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IProtectedOverrideEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
    }
}
