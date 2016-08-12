using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConversionOperatorWrapper : AbstractWrapper<IConversionOperator>
    {
        public ConversionOperatorWrapper(IConversionOperator conversionOperator)
            : base(conversionOperator)
        {
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            Value = new ConversionOperator()
            {
                Attributes = conversionOperator.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(conversionOperator.Body).Value,
                OperatorType = conversionOperator.OperatorType,
                Parameter = new OperatorParameterWrapper(conversionOperator.Parameter).Value,
                ReturnAttributes = conversionOperator.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(conversionOperator.ReturnType).Value
            };
        }
    }
}
