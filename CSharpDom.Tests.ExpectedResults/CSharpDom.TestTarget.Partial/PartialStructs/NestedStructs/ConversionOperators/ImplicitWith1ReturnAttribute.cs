namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
