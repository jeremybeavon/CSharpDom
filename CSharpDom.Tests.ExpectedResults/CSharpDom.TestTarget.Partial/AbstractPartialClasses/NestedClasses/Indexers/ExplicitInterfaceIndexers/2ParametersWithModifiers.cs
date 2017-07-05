namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
