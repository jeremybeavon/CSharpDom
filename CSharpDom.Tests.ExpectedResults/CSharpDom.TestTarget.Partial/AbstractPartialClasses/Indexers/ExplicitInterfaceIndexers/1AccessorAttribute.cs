namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute : IInterfaceWithIndexer
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
