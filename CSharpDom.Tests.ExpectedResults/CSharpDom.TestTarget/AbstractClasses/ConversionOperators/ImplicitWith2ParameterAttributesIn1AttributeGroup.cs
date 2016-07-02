namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
