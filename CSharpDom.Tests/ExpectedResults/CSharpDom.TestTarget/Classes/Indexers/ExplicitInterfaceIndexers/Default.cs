namespace CSharpDom.TestTarget.Classes.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithExplicitInterfaceIndexer : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
