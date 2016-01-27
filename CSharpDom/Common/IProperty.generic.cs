namespace CSharpDom.Common
{
    public interface IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IProperty,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasPropertyType<TTypeReference>,
        IHasAccessors<TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
    }
}
