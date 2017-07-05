namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithProtectedIndexer
    {
        public partial class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
