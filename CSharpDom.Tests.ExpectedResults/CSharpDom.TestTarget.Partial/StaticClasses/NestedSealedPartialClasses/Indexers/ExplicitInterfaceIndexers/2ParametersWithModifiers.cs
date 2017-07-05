namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
