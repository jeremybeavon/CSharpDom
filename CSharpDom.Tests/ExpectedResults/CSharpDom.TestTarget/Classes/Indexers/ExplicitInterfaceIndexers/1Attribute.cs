namespace CSharpDom.TestTarget.Classes.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithExplicitInterfaceIndexerWith1Attribute : IInterfaceWithIndexer
    {
        [Attribute1]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
