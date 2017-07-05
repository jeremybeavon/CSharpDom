namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public struct Struct : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
