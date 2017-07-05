namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
