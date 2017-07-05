namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithImplicitConversionOperator
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
