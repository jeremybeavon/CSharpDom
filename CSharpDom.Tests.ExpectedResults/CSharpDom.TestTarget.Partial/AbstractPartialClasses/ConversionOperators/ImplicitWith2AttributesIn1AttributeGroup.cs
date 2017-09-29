namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static implicit operator AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
