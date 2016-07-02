namespace CSharpDom.TestTarget.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedStructWithExplicitInterfaceIndexerWith2Parameters
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
