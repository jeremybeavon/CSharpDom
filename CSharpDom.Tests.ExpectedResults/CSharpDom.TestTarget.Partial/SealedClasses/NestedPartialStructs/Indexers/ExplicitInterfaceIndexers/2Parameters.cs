namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceIndexerWith2Parameters
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
