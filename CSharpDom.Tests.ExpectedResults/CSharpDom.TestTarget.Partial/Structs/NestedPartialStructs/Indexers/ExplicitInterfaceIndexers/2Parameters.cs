namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedStructWithExplicitInterfaceIndexerWith2Parameters
    {
        public struct Struct : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
