namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
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
