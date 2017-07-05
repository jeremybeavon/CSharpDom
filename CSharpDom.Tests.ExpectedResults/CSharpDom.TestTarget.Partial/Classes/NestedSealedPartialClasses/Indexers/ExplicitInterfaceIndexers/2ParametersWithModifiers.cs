namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
