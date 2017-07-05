namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWith2Parameters
    {
        public struct Struct
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
