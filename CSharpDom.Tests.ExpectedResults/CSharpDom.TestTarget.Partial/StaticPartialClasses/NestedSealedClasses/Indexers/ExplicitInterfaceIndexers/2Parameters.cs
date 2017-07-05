namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters
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
