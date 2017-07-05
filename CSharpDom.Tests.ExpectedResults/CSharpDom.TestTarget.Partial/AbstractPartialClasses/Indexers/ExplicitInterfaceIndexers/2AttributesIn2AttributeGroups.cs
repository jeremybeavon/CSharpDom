namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups : IInterfaceWithIndexer
    {
        [Attribute1]
        [Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
