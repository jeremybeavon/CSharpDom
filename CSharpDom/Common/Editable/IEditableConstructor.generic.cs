namespace CSharpDom.Common.Editable
{
    public interface IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IEditableConstructor,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableParameters<TParameter>,
        IHasEditableBody<TMethodBody>,
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TParameter : IEditableConstructorParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}