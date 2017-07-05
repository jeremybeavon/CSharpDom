namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
