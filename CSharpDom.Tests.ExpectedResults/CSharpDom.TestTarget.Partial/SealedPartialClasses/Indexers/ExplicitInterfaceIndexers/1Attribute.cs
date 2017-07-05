namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith1Attribute : IInterfaceWithIndexer
    {
        [Attribute1]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
