namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithIndexer
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
