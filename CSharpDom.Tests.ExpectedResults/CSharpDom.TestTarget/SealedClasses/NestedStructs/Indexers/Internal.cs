namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithInternalIndexer
    {
        public struct Struct
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
