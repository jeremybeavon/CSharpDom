namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IEditableStaticClassConstant,
        IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TTypeReference : IEditableTypeReference
        where TConstant : IEditableConstant
    {
    }
}