namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers : IInterfaceWithIndexerWithModifiers
    {
        string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
        {
            set { }
        }
    }
}
