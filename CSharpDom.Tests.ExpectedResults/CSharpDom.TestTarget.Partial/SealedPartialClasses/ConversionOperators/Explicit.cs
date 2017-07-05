namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperator
    {
        public static explicit operator SealedClassWithExplicitConversionOperator(string text)
        {
            return default(SealedClassWithExplicitConversionOperator);
        }
    }
}
