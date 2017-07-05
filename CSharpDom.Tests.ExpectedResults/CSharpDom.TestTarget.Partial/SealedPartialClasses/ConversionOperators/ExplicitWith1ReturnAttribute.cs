namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
