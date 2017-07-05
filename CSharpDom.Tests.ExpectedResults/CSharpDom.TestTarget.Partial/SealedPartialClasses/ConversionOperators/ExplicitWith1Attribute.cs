namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
