namespace CSharpDom.TestTarget.Classes.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithExplicitInterfaceIndexerWith2Parameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
        {
            set { }
        }
    }
}
