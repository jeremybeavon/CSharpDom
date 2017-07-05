namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2Parameters
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
