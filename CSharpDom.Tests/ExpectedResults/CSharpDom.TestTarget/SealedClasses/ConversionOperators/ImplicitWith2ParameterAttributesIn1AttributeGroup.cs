namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
