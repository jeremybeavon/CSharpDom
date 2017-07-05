namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
