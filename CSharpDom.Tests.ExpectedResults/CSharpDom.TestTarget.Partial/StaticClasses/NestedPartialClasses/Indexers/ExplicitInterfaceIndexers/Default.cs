namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceIndexer
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
