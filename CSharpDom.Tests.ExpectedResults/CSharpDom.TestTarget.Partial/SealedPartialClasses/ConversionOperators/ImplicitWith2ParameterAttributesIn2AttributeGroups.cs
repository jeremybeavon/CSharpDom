namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
