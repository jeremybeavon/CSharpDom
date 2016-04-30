namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
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
