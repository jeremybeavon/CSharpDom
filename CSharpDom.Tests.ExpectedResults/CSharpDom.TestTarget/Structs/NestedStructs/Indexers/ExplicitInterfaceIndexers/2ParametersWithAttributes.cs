namespace CSharpDom.TestTarget.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithParameters
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
