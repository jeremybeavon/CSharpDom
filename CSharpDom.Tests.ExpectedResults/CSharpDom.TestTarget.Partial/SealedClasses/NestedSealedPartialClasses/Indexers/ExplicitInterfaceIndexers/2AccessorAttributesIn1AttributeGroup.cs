namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
