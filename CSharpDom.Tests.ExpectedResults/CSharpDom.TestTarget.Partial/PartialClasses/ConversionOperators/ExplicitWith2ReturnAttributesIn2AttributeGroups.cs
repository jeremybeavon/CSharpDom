namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static explicit operator ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
