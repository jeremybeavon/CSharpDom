namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup : IInterfaceWithIndexer
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
