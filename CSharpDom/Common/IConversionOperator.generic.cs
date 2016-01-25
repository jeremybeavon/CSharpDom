namespace CSharpDom.Common
{
    public interface IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IConversionOperator,
        IHasAttributes<TAttributeGroup>,
        IHasReturnAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasConversionOperatorType,
        IHasReturnType<TTypeReference>,
        IHasParameter<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
    }
}
