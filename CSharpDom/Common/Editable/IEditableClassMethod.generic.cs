namespace CSharpDom.Common.Editable
{
    public interface IEditableClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        IEditableClassMethod,
        IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IHasEditableClassMemberInheritanceModifier,
        IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}