namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers
{
    public struct StructWithNestedSealedPartialClassWithProtectedIndexer
    {
        public sealed partial class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
