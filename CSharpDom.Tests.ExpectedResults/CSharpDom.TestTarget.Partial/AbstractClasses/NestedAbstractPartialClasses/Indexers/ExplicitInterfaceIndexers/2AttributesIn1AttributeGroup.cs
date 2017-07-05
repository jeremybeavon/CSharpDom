namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
