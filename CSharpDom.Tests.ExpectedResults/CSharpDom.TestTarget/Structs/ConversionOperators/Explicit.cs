namespace CSharpDom.TestTarget.Structs.ConversionOperators
{
    public struct StructWithExplicitConversionOperator
    {
        public static explicit operator StructWithExplicitConversionOperator(string text)
        {
            return default(StructWithExplicitConversionOperator);
        }
    }
}
