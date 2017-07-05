namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2Parameters
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
