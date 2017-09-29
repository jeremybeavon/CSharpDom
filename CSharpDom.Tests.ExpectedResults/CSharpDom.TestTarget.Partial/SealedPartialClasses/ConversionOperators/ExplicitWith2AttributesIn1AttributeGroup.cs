namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static explicit operator SealedPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(SealedPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
