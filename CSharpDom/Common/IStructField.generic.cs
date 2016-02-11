namespace CSharpDom.Common
{
    public interface IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IStructField,
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TField : IField
    {
    }
}
