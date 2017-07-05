namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1]string text)
            {
                return default(Struct);
            }
        }
    }
}
