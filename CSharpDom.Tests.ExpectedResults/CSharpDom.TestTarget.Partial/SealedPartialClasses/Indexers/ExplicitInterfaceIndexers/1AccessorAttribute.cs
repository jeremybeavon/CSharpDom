namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute : IInterfaceWithIndexer
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
