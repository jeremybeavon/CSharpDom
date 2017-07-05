namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
