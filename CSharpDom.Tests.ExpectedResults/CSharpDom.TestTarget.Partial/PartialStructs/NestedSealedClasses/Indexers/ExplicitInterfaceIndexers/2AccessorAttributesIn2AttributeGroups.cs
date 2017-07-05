namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithIndexer
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
