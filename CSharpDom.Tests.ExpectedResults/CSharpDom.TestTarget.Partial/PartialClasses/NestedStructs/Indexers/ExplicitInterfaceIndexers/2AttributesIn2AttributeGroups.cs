namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithIndexer
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
