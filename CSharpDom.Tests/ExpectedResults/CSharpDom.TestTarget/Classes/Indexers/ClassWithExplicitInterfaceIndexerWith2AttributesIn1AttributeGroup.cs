namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup : IInterfaceWithIndexer
    {
        [Attribute1, Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
