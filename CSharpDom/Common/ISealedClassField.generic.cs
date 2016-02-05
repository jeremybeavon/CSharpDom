namespace CSharpDom.Common
{
    public interface ISealedClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        ISealedClassField,
        IField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
    {
    }
}
