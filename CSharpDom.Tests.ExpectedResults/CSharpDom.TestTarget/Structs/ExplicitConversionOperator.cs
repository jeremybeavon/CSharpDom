namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithExplicitConversionOperator
    {
        public static explicit operator StructWithExplicitConversionOperator(string text)
        {
            return default(StructWithExplicitConversionOperator);
        }
    }
}
