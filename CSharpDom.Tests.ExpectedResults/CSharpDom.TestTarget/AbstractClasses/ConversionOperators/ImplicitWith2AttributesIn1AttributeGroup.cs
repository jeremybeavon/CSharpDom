namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
