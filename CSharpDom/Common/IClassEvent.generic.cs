namespace CSharpDom.Common
{
    public interface IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IClassEvent,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasClassMemberInheritanceModifier,
        IHasFieldAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
    {
    }
}
