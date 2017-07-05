namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.ConversionOperators
{
    public struct StructWithNestedPartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
