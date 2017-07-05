namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
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
