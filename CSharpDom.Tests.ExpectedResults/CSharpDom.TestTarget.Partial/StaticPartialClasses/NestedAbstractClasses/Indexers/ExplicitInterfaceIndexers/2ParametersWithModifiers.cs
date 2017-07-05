namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
