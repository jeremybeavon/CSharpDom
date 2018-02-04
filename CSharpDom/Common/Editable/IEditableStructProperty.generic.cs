namespace CSharpDom.Common.Editable
{
    public interface IEditableStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableStructProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasEditableStructMemberInheritanceModifier,
        IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableStructAccessor
    {
    }
}