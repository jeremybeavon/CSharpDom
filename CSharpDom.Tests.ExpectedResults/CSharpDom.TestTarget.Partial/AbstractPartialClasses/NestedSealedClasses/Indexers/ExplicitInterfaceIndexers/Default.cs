namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceIndexer
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
