namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexer : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
