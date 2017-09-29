namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperator
    {
        public static implicit operator SealedPartialClassWithImplicitConversionOperator(string text)
        {
            return default(SealedPartialClassWithImplicitConversionOperator);
        }
    }
}
