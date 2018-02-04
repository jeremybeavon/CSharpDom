namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableStaticClassProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableStaticClassAccessor
    {
    }
}