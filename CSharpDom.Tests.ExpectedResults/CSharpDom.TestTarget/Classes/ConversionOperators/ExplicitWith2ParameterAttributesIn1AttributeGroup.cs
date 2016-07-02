namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
