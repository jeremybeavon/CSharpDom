namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithIndexer
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
