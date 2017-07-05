namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
