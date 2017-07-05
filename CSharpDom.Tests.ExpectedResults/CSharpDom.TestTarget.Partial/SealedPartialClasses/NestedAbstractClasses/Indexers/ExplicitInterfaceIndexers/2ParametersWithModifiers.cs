namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
