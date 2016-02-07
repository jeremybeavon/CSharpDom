namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithImplicitConversionOperator
    {
        public static implicit operator StructWithImplicitConversionOperator(string text)
        {
            return default(StructWithImplicitConversionOperator);
        }
    }
}
