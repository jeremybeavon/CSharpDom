namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
