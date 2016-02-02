namespace CSharpDom.Common
{
    public interface IStructField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IStructField,
        IField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
    }
}
