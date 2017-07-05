namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
