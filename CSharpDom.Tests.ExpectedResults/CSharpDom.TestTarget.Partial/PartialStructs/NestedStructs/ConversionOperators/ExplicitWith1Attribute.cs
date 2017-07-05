namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithExplicitConversionOperatorWith1Attribute
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
