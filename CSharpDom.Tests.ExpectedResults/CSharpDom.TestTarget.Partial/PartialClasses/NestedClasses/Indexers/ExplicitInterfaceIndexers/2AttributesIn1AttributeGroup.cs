namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1, Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
