namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator SealedPartialClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedPartialClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
