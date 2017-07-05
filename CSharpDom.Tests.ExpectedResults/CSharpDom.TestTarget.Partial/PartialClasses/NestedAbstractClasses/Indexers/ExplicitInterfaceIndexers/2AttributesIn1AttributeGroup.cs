namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
