namespace CSharpDom.Common
{
    public interface IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IStaticClassEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasFieldAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TDelegateReference : IDelegateReference
    {
    }
}
