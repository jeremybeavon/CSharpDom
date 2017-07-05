namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static explicit operator SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
