using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        IEditablePartialMethodImplementation,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableReturnAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableParameters<TParameter>,
        IHasEditableBody<TMethodBody>,
        IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TParameter : IEditableMethodParameter
        where TMethodBody : IEditableMethodBody
    {
    }
}