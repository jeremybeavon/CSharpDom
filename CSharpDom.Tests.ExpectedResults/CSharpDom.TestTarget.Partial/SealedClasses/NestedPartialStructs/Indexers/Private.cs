namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithPrivateIndexer
    {
        public struct Struct
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
