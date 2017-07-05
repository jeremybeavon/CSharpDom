namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithPrivateIndexer
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
