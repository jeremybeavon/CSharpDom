namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups : IInterfaceWithIndexer
    {
        string IInterfaceWithIndexer.this[int index]
        {
            [Attribute1]
            [Attribute2]
            get { return default(string); }
            [Attribute1]
            [Attribute2]
            set { }
        }
    }
}
