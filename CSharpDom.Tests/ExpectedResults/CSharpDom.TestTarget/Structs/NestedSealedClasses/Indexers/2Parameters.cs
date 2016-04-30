namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithIndexerWith2Parameters
    {
        public sealed class Class
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
