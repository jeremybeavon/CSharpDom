namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public struct Struct : IInterfaceWithIndexer
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
