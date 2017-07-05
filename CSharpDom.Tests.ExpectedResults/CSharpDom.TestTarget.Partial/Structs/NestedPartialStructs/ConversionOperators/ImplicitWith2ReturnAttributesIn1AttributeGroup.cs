namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [return: Attribute1, Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
