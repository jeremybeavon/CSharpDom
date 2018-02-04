namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IEditableStaticClassField,
        IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TTypeReference : IEditableTypeReference
        where TField : IEditableField
    {
    }
}