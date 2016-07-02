namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith1Attribute : IInterfaceWithIndexer
    {
        [Attribute1]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
