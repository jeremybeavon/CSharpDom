namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceIndexer
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
