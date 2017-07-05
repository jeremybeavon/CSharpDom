namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup
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
