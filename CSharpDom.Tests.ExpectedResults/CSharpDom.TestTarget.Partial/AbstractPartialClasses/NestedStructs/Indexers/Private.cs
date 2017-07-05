namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithPrivateIndexer
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
