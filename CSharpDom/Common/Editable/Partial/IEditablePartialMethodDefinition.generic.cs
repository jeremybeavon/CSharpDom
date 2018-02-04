using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> :
        IEditablePartialMethodDefinition,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableReturnAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableParameters<TParameter>,
        IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TParameter : IEditableMethodParameter
    {
    }
}