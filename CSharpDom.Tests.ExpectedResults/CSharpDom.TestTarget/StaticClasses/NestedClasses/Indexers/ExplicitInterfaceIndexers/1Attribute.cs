namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
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
