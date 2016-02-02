namespace CSharpDom.Common
{
    public interface IClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IClassField,
        IHasName,
        IHasClassMemberVisibilityModifier,
        IHasFieldModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasFieldType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
    }
}
