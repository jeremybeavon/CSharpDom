namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
