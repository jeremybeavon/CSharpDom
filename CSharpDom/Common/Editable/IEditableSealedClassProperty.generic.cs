namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IEditableSealedClassProperty,
        IHasEditableSealedClassMemberInheritanceModifier,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableClassAccessor
    {
    }
}