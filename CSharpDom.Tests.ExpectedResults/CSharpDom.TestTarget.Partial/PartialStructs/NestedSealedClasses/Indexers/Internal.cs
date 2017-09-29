namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithNestedSealedClassWithInternalIndexer
    {
        public sealed class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
