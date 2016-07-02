namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups : IInterfaceWithIndexer
    {
        [Attribute1]
        [Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
