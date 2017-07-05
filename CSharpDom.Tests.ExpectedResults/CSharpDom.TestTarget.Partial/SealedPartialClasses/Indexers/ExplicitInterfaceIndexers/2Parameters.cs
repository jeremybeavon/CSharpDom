namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith2Parameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
        {
            set { }
        }
    }
}
