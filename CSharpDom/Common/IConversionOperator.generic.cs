namespace CSharpDom.Common
{
    public interface IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IConversionOperator,
        IHasAttributes<TAttributeGroup>,
        IHasReturnAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasConversionOperatorType,
        IHasReturnType<TTypeReference>,
        IHasParameter<TParameter>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
