namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
