namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWith2ParametersWithAttributes
    {
        public struct Struct
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
