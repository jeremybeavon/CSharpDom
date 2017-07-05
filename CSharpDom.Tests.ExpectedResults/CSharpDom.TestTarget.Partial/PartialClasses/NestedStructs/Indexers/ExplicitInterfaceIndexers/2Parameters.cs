namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceIndexerWith2Parameters
    {
        public struct Struct : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
