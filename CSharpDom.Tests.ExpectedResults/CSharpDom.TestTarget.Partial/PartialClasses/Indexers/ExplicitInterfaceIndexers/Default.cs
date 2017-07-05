namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithExplicitInterfaceIndexer : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
