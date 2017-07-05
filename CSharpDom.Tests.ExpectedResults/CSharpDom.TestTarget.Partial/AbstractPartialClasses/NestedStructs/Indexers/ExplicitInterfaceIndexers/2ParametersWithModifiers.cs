namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
