namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
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
