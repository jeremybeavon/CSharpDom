namespace CSharpDom.TestTarget.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithPrivateIndexer
    {
        public struct Struct
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
