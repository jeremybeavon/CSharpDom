namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexer
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
