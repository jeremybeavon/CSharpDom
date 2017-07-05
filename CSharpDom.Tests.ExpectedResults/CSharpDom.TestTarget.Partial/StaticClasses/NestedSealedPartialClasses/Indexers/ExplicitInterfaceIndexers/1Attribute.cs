namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith1Attribute
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
