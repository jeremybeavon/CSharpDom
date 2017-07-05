namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            [Attribute1]
            [Attribute2]
            get { return default(string); }
            [Attribute1]
            [Attribute2]
            set { }
        }
    }
}
