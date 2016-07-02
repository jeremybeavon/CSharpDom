namespace CSharpDom.TestTarget.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
