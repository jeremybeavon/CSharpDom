namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
