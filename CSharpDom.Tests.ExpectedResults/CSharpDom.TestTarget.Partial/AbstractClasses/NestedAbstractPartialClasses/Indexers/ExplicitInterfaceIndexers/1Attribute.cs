namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public abstract class Class : IInterfaceWithIndexer
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
