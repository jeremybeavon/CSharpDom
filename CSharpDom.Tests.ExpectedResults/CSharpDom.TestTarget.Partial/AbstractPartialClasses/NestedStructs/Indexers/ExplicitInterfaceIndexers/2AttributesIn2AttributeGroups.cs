namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
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
