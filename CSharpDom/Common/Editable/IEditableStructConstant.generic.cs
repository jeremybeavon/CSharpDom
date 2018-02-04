namespace CSharpDom.Common.Editable
{
    public interface IEditableStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IEditableStructConstant,
        IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TTypeReference : IEditableTypeReference
        where TConstant : IEditableConstant
    {
    }
}