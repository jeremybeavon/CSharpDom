namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithInternalIndexer
    {
        public struct Struct
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
