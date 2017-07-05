namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith2Parameters
    {
        public struct Struct
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
