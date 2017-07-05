namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithImplicitConversionOperator
    {
        public struct Struct
        {
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
