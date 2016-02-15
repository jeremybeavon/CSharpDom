using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ConversionOperatorFactory : AbstractFactory<IConversionOperator, ConversionOperator>
    {
        public ConversionOperatorFactory(IConversionOperator conversionOperator)
            : base(conversionOperator)
        {
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            Value = new ConversionOperator()
            {
                Attributes = conversionOperator.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(conversionOperator.Body).Value,
                OperatorType = conversionOperator.OperatorType,
                Parameter = new OperatorParameterFactory(conversionOperator.Parameter).Value,
                ReturnAttributes = conversionOperator.ReturnAttributes.ToAttributeListUsingFactory(),
                ReturnType = new TypeReferenceFactory(conversionOperator.ReturnType).Value
            };
        }
    }
}
