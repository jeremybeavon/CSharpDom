namespace CSharpDom.Common.Editable
{
    public interface IEditableClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IEditableClassConstant,
        IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TTypeReference : IEditableTypeReference
        where TConstant : IEditableConstant
    {
    }
}