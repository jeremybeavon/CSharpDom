namespace CSharpDom.Common.Editable
{
    public interface IEditableConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IEditableConversionOperator,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableReturnAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableConversionOperatorType,
        IHasEditableReturnType<TTypeReference>,
        IHasEditableParameter<TParameter>,
        IHasEditableBody<TMethodBody>,
        IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableOperatorParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}