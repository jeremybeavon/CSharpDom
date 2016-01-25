namespace CSharpDom.Common
{
    public interface IEvent<TAttributeGroup, TDeclaringType, TTypeReference> :
        IEvent,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasFieldAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
    {
    }
}
