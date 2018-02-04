namespace CSharpDom.Common.Editable
{
    public interface IEditableClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableClassProperty,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasEditableClassMemberInheritanceModifier,
        IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableClassAccessor
    {
    }
}