namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup : IInterfaceWithIndexer
    {
        [Attribute1, Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
