namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithInternalIndexer
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
