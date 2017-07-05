namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithIndexer
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
