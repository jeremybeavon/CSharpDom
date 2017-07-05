namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceIndexerWith1Attribute
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
