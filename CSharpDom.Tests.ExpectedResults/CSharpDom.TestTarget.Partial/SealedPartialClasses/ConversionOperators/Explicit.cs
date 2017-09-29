namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperator
    {
        public static explicit operator SealedPartialClassWithExplicitConversionOperator(string text)
        {
            return default(SealedPartialClassWithExplicitConversionOperator);
        }
    }
}
