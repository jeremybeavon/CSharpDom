namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup : IInterfaceWithIndexer
    {
        [Attribute1, Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
