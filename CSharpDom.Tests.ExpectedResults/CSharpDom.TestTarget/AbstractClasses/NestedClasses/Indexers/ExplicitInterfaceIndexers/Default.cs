namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceIndexer
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
