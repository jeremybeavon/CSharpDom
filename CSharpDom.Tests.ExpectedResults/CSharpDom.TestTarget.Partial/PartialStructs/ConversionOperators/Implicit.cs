namespace CSharpDom.TestTarget.Partial.PartialStructs.ConversionOperators
{
    public partial struct PartialStructWithWithImplicitConversionOperator
    {
        public static implicit operator StructWithImplicitConversionOperator(string text)
        {
            return default(StructWithImplicitConversionOperator);
        }
    }
}
