namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public abstract class Class : IInterfaceWithIndexer
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
