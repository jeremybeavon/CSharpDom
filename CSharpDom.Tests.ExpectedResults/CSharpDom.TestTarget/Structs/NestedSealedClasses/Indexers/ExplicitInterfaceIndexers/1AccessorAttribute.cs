namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
