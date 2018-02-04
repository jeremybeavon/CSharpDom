namespace CSharpDom.Common.Editable
{
    public interface IEditableStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IEditableStructField,
        IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TTypeReference : IEditableTypeReference
        where TField : IEditableField
    {
    }
}