namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public abstract class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
