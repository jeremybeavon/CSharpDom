namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith2Parameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
        {
            set { }
        }
    }
}
