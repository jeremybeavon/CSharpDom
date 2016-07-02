namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters
    {
        public sealed class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
