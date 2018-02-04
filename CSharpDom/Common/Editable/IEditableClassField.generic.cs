namespace CSharpDom.Common.Editable
{
    public interface IEditableClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IEditableClassField,
        IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TTypeReference : IEditableTypeReference
        where TField : IEditableField
    {
    }
}