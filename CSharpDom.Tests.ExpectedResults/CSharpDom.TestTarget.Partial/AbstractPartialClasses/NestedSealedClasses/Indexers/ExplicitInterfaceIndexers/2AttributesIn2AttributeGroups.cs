namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            [Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
