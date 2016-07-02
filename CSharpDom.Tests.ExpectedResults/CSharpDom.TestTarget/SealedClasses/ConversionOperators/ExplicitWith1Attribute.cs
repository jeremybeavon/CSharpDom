namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
