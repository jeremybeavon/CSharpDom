namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
