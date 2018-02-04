namespace CSharpDom.Common.Editable
{
    public interface IEditableExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> :
        IEditableExplicitInterfaceProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasEditableExplicitInterface<TInterfaceReference>,
        IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TInterfaceReference : IEditableInterfaceReference
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAccessor
    {
    }
}