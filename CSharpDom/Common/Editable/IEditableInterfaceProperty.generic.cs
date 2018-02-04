namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableInterfaceProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableInterfaceType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableInterfaceAccessor
    {
    }
}