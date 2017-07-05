namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers
{
    public partial struct PartialStructWithWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
