namespace CSharpDom.Common
{
    public interface IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IStructEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasStructMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TDelegateReference : IDelegateReference
    {
    }
}
