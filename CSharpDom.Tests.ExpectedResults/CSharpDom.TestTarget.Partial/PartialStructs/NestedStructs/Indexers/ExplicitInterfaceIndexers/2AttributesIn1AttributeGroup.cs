namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithIndexer
        {
            [Attribute1, Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
