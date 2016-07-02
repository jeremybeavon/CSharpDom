namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static implicit operator ClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
