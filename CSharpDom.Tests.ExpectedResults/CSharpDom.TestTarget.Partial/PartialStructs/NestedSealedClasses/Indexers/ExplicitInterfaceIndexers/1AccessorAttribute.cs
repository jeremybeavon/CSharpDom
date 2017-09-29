namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
