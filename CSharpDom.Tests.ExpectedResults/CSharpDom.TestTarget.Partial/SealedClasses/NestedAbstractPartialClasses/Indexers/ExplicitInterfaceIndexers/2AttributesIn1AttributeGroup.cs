namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
