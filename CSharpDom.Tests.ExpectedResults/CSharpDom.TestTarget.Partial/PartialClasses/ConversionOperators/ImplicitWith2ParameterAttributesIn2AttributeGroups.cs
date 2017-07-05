namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static implicit operator ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
