namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
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
