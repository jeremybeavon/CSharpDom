namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters
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
