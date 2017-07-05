namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithIndexer
        {
            [Attribute1, Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
