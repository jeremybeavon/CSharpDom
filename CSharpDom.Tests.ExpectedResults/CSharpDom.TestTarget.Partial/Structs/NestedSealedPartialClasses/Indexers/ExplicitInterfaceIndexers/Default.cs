namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceIndexer
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
