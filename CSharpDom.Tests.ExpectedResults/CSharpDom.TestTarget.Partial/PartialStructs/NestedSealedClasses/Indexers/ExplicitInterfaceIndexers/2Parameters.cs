namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public sealed class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
