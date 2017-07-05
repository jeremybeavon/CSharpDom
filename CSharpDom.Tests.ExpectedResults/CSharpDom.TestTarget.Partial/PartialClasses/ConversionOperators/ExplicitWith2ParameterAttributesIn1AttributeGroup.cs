namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
