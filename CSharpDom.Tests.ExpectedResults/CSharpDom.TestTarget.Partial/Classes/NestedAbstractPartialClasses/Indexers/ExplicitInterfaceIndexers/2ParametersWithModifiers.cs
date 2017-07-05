namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
