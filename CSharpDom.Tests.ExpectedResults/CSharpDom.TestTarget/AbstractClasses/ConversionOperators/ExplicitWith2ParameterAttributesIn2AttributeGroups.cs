namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
