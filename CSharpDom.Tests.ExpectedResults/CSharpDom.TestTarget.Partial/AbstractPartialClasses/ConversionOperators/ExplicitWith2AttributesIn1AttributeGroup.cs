namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static explicit operator AbstractPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(AbstractPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
