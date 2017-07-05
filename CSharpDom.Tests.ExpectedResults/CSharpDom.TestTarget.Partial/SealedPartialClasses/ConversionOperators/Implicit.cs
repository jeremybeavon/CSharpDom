namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperator
    {
        public static implicit operator SealedClassWithImplicitConversionOperator(string text)
        {
            return default(SealedClassWithImplicitConversionOperator);
        }
    }
}
