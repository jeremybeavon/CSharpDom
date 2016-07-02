namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
