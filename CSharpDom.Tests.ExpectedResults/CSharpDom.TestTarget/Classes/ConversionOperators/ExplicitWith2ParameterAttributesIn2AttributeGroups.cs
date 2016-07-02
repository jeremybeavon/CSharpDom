namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
