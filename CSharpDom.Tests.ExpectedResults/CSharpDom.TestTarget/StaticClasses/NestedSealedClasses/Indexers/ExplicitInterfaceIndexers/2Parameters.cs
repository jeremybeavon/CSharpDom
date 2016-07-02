namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters
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
