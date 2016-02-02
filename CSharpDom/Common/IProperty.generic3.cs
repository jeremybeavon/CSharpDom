namespace CSharpDom.Common
{
    public interface IProperty<TAttributeGroup, TDeclaringType, TTypeReference> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasPropertyType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
    {
    }
}
