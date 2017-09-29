namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static explicit operator PartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(PartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
