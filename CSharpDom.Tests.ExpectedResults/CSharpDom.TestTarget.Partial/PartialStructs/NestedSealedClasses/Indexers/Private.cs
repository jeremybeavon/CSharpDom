namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithPrivateIndexer
    {
        public sealed class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
