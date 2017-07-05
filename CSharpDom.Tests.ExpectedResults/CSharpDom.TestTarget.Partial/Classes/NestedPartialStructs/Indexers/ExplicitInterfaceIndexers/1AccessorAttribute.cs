namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute
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
