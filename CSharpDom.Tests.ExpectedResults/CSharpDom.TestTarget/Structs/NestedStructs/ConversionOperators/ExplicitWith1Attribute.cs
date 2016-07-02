namespace CSharpDom.TestTarget.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithExplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
