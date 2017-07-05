namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers
{
    public struct StructWithNestedAbstractPartialClassWithPrivateIndexer
    {
        public abstract partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
