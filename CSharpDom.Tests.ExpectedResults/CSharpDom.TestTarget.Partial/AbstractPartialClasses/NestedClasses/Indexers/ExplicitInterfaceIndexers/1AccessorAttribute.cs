namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
