namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
