namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceIndexer
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
