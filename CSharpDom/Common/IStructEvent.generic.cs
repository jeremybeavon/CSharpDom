namespace CSharpDom.Common
{
    public interface IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IStructEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TDelegateReference : IDelegateReference
    {
    }
}
