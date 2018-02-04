namespace CSharpDom.Common.Editable
{
    public interface IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IEditableConstantGroup,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableFieldType<TTypeReference>,
        IHasEditableConstants<TConstant>,
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TConstant : IEditableConstant
    {
    }
}