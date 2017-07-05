namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute
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
