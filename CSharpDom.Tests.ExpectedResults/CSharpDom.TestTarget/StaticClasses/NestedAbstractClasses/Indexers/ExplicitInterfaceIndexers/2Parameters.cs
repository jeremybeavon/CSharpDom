namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters
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
