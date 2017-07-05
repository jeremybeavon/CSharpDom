namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceIndexer
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
