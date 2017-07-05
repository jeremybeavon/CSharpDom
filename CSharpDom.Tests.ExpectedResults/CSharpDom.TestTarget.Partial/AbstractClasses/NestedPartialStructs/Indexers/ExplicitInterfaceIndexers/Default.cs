namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceIndexer
    {
        public struct Struct : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
