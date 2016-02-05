namespace CSharpDom.Common
{
    public interface IClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IClassField,
        IField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
    {
    }
}
