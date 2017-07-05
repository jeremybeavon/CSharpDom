namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
