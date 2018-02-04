namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        IEditableSealedClassMethod,
        IHasEditableSealedClassMemberInheritanceModifier,
        IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}