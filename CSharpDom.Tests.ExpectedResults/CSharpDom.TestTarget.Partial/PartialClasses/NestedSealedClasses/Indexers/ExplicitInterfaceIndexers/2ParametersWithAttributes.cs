namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
