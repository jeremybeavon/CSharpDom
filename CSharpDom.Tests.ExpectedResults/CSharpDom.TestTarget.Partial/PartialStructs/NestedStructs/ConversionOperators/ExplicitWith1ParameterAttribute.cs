namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute
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
