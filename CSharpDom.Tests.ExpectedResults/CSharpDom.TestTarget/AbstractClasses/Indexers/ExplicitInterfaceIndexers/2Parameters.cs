namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith2Parameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
        {
            set { }
        }
    }
}
