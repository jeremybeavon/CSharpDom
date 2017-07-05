namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceIndexer
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
