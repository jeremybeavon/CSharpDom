namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableAbstractProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableAbstractType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAbstractAccessor
    {
    }
}