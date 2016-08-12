namespace CSharpDom.TestTarget.Structs.ConversionOperators
{
    public struct StructWithImplicitConversionOperator
    {
        public static implicit operator StructWithImplicitConversionOperator(string text)
        {
            return default(StructWithImplicitConversionOperator);
        }
    }
}
