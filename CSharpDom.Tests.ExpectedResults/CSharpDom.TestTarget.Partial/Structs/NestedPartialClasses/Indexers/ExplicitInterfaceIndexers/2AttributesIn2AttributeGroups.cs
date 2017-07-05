namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
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
