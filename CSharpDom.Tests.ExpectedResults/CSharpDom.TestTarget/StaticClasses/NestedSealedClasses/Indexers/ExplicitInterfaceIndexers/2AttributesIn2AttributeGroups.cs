namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithIndexer
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
