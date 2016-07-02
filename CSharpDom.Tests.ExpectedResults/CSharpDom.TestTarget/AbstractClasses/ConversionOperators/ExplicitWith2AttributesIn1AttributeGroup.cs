namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
