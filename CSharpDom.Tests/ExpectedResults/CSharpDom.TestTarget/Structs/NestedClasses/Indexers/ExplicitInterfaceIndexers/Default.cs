namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedClassWithExplicitInterfaceIndexer
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
