namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
