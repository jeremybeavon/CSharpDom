namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithExplicitInterfaceIndexerWith1Attribute : IInterfaceWithIndexer
    {
        [Attribute1]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
