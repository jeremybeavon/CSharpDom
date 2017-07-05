namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
