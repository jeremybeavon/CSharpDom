namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithIndexer
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
