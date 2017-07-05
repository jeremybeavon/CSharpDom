namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute
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
