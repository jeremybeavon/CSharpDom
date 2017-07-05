namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithPublicIndexer
    {
        public struct Struct
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
