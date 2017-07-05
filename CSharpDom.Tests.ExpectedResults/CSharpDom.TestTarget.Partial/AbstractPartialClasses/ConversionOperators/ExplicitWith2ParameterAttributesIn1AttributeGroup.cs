namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
