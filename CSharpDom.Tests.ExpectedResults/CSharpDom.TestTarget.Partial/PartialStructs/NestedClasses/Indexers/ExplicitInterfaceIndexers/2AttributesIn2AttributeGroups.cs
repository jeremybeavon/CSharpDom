namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithIndexer
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
}
