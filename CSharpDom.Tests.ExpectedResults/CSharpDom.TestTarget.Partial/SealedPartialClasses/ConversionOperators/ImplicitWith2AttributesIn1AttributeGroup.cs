namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
