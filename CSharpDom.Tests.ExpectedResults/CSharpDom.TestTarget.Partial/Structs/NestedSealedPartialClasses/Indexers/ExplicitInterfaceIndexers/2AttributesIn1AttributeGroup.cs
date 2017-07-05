namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithIndexer
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
