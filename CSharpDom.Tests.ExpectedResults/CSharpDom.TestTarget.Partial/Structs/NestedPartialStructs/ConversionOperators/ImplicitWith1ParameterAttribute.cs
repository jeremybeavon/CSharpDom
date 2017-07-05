namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1]string text)
            {
                return default(Struct);
            }
        }
    }
}
