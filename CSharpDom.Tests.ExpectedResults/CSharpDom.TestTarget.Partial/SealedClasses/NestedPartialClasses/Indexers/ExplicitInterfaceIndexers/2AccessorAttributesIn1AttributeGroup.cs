namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
