namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
