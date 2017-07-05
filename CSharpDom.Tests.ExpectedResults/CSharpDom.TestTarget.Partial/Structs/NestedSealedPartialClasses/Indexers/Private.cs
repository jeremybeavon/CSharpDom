namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers
{
    public struct StructWithNestedSealedPartialClassWithPrivateIndexer
    {
        public sealed partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
