namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperator
    {
        public static explicit operator SealedClassWithExplicitConversionOperator(string text)
        {
            return default(SealedClassWithExplicitConversionOperator);
        }
    }
}
