namespace CSharpDom.Common
{
    public interface IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IOperatorOverload,
        IHasOperatorOverloadType,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasReturnType<TTypeReference>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
    }
}
