namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithIndexer
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
