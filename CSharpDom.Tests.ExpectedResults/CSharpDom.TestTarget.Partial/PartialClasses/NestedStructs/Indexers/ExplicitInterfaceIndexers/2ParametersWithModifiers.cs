namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
