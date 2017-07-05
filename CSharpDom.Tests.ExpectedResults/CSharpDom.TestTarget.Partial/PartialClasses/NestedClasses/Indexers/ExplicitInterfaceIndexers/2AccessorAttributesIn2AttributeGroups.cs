namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithIndexer
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
}
