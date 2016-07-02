namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithPublicIndexer
    {
        public struct Struct
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
