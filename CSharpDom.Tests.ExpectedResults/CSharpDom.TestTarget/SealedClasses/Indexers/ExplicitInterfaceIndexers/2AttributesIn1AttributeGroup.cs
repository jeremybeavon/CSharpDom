namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup : IInterfaceWithIndexer
    {
        [Attribute1, Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
