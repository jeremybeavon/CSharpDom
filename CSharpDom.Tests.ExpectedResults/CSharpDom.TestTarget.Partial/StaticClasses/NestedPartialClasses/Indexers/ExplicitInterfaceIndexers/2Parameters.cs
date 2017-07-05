namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2Parameters
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
