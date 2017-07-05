namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
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
