namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static implicit operator ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
