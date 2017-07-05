namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
