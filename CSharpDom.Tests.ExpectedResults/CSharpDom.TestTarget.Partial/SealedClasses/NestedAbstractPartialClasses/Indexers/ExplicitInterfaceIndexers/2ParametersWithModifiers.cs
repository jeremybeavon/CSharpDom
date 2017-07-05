namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
