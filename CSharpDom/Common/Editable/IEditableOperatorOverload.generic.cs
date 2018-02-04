namespace CSharpDom.Common.Editable
{
    public interface IEditableOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IEditableOperatorOverload,
        IHasEditableOperatorOverloadType,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableReturnType<TTypeReference>,
        IHasEditableParameters<TParameter>,
        IHasEditableBody<TMethodBody>,
        IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableOperatorParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}