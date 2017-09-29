namespace CSharpDom.TestTarget.Partial.PartialStructs.ConversionOperators
{
    public partial struct PartialStructWithImplicitConversionOperator
    {
        public static implicit operator PartialStructWithImplicitConversionOperator(string text)
        {
            return default(PartialStructWithImplicitConversionOperator);
        }
    }
}
