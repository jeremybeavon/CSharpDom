namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
