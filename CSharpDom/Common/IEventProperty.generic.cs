namespace CSharpDom.Common
{
    public interface IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEventProperty,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
    {
    }
}
