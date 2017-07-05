namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceIndexerWith1Attribute
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
