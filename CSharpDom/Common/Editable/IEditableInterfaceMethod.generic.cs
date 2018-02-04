namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IEditableInterfaceMethod,
        IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableInterfaceType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
    {
    }
}