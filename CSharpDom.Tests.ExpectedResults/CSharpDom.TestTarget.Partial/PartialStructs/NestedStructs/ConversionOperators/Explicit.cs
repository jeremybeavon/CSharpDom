namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithExplicitConversionOperator
    {
        public struct Struct
        {
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
