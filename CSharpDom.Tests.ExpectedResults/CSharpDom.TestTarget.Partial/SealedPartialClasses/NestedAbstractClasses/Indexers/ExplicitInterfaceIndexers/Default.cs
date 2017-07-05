namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexer
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
