namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
