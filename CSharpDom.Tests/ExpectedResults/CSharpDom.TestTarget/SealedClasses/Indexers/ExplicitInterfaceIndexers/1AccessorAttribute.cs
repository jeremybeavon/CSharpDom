namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            [Attribute1]
            get { return default(string); }
            [Attribute1]
            set { }
        }
    }
}
