namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public struct Struct : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
