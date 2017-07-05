namespace CSharpDom.TestTarget.Partial.PartialStructs.ConversionOperators
{
    public partial struct PartialStructWithWithExplicitConversionOperator
    {
        public static explicit operator StructWithExplicitConversionOperator(string text)
        {
            return default(StructWithExplicitConversionOperator);
        }
    }
}
