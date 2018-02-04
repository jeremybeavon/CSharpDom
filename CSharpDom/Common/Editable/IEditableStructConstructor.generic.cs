namespace CSharpDom.Common.Editable
{
    public interface IEditableStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IEditableStructConstructor,
        IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TParameter : IEditableConstructorParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}