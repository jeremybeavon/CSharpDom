namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public sealed class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
