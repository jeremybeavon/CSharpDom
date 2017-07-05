namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexer
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
