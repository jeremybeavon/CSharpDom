namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceIndexer
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
