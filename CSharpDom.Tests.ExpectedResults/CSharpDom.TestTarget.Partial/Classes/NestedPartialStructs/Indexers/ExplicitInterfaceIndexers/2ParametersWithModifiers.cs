namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public struct Struct : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
