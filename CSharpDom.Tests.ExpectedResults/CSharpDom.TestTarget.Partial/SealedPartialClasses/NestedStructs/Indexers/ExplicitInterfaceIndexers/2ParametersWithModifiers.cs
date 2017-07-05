namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
