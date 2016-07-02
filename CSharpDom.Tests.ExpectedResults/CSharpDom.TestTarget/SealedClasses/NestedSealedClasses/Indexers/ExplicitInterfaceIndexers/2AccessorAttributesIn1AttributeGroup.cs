namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
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
