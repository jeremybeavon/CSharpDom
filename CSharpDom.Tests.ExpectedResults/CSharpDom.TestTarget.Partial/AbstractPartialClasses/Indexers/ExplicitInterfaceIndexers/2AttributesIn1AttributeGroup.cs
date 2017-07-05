namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup : IInterfaceWithIndexer
    {
        [Attribute1, Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
