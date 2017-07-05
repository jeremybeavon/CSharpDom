namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedStructWithExplicitInterfaceIndexerWith1Attribute
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
