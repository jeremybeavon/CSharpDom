namespace CSharpDom.Common
{
    public interface IEventProperty<TAttributeGroup, TDeclaringType, TTypeReference> :
        IEventProperty,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
    }
}
