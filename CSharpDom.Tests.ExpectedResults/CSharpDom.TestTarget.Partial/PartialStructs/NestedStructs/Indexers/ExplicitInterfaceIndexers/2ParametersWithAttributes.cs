namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes
    {
        public struct Struct : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
