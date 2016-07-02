namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
