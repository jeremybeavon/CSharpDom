namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers
{
    public partial struct PartialStructWithWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
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
