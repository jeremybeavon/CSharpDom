namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
