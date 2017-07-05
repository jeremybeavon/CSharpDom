namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
