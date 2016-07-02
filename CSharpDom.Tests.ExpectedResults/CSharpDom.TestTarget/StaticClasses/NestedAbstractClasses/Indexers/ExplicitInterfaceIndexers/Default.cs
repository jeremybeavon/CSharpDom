namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceIndexer
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
