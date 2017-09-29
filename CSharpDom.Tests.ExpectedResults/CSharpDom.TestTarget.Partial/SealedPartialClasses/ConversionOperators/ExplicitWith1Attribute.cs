namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator SealedPartialClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedPartialClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
