namespace CSharpDom.TestTarget.Partial.PartialStructs.ConversionOperators
{
    public partial struct PartialStructWithExplicitConversionOperator
    {
        public static explicit operator PartialStructWithExplicitConversionOperator(string text)
        {
            return default(PartialStructWithExplicitConversionOperator);
        }
    }
}
