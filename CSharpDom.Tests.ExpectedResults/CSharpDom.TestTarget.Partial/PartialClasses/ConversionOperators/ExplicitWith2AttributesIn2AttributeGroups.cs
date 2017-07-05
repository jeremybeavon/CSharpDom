namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static explicit operator ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
