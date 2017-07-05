namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithInternalIndexer
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
