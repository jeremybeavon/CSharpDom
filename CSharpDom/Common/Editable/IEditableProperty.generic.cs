namespace CSharpDom.Common.Editable
{
    public interface IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableProperty,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditablePropertyType<TTypeReference>,
        IHasEditableAccessors<TAccessor>,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAccessor
    {
    }
}