namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
