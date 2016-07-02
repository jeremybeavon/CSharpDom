namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums
{
    public struct StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public enum Enum
            {
            }
        }
    }
}
