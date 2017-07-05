namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithImplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
