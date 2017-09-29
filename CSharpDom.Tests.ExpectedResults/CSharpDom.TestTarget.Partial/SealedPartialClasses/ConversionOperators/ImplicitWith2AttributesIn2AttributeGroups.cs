namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static implicit operator SealedPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(SealedPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
