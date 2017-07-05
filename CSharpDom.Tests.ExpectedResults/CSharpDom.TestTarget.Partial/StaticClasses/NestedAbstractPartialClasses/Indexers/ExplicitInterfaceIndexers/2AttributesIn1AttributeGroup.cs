namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithIndexer
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
