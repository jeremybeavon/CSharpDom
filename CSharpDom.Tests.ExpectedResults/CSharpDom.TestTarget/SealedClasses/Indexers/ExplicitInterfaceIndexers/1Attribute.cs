namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexerWith1Attribute : IInterfaceWithIndexer
    {
        [Attribute1]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
