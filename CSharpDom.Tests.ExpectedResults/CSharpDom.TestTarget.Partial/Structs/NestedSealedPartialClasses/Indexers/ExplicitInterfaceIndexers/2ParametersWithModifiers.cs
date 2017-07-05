namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
