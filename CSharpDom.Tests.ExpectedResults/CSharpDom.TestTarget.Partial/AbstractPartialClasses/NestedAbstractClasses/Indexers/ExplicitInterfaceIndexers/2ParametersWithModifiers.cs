namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public abstract class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
