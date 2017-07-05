namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
