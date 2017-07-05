namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
