namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
