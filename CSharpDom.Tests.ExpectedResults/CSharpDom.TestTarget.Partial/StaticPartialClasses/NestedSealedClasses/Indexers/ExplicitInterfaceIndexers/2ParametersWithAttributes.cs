namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
