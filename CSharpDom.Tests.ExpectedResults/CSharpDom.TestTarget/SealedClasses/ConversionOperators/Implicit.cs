namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperator
    {
        public static implicit operator SealedClassWithImplicitConversionOperator(string text)
        {
            return default(SealedClassWithImplicitConversionOperator);
        }
    }
}
