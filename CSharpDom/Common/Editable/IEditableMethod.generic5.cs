namespace CSharpDom.Common.Editable
{
    public interface IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IEditableMethod,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableReturnAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableReturnType<TTypeReference>,
        IHasEditableParameters<TParameter>,
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
    {
    }
}