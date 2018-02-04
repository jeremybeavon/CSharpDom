namespace CSharpDom.Common.Editable
{
    public interface IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        IEditableDelegateType,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableReturnType<TTypeReference>,
        IHasEditableParameters<TParameter>,
        IVisitable<IEditableVisitor>,
        IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableDelegateParameter
    {
    }
}