namespace CSharpDom.Common.Editable
{
    public interface IEditableClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IEditableClassConstructor,
        IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TParameter : IEditableConstructorParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}