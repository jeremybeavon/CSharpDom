namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers
{
    public partial struct PartialStructWithWithNestedStructWithIndexerWith1AccessorAttribute
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
