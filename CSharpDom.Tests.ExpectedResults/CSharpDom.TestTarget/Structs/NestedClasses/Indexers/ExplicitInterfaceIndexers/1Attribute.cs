namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
