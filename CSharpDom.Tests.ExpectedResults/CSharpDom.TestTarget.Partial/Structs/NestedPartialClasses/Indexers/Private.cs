namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithPrivateIndexer
    {
        public partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
