namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
