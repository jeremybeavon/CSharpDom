namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
