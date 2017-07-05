namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.ConversionOperators
{
    public partial struct PartialStructWithWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1][Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
