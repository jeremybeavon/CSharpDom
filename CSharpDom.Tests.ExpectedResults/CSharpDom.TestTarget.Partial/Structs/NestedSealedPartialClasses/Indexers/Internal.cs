namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers
{
    public struct StructWithNestedSealedPartialClassWithInternalIndexer
    {
        public sealed partial class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
