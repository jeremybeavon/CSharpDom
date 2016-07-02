namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithNewIndexer
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
