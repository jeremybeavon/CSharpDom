namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers
{
    public partial struct PartialStructWithWithNestedStructWithInternalIndexer
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
