namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
