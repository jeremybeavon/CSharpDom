namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithExplicitInterfaceIndexerWith1AccessorAttribute : IInterfaceWithIndexer
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
