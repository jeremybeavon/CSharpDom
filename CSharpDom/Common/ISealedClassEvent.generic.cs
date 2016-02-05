namespace CSharpDom.Common
{
    public interface ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        ISealedClassEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasFieldAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
    }
}
