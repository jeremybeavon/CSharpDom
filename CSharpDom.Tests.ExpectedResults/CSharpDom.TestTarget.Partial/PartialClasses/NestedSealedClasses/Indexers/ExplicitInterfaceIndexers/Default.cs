namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceIndexer
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
