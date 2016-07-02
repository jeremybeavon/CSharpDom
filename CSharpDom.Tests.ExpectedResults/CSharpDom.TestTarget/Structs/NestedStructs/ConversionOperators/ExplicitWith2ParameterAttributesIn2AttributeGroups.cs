namespace CSharpDom.TestTarget.Structs.NestedStructs.ConversionOperators
{
    public struct StructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1][Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
