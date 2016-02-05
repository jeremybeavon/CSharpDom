namespace CSharpDom.Common
{
    public interface IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IStaticClassField,
        IField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
    {
    }
}
