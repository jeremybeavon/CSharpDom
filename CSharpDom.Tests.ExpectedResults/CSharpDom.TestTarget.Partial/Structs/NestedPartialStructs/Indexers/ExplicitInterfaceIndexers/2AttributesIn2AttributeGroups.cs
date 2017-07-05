namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithIndexer
        {
            [Attribute1]
            [Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
