namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IEditableNestedDelegate,
        IHasEditableDeclaringType<TDeclaringType>,
        IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableDelegateParameter
    {
    }
}