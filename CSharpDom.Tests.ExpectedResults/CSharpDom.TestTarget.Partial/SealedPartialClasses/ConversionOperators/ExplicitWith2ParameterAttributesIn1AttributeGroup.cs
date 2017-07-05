namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static explicit operator SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
