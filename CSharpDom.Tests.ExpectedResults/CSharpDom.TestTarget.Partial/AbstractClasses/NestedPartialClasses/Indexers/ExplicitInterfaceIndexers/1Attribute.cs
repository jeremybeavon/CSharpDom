namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceIndexerWith1Attribute
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
