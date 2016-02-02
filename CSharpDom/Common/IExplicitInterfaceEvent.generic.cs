namespace CSharpDom.Common
{
    public interface IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> :
        IExplicitInterfaceEvent,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasExplicitInterface<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
