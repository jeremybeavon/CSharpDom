namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers : IInterfaceWithIndexerWithModifiers
    {
        string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
        {
            set { }
        }
    }
}
