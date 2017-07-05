namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
