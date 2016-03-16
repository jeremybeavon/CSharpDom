namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup : IInterfaceWithIndexer
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
