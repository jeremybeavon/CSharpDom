namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public abstract class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
