namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
