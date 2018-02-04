namespace CSharpDom.Common.Editable
{
    public interface IEditableExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        IEditableExplicitInterfaceMethod,
        IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IHasEditableExplicitInterface<TInterfaceReference>,
        IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TInterfaceReference : IEditableInterfaceReference
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}