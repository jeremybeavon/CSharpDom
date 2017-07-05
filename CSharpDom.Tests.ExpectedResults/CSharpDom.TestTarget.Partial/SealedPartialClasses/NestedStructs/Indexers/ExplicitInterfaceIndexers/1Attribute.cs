namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceIndexerWith1Attribute
    {
        public struct Struct : IInterfaceWithIndexer
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
