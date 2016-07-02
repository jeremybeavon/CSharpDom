namespace CSharpDom.TestTarget.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
