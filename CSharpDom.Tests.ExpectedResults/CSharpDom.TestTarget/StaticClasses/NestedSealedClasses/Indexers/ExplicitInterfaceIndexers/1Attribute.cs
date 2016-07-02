namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute
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
