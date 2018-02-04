namespace CSharpDom.Common.Editable
{
    public interface IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IEditableFieldGroup,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableFieldType<TTypeReference>,
        IHasEditableFields<TField>,
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TField : IEditableField
    {
    }
}