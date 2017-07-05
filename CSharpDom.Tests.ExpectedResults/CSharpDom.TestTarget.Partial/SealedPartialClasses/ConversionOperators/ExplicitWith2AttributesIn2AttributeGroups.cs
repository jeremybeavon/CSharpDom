namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
