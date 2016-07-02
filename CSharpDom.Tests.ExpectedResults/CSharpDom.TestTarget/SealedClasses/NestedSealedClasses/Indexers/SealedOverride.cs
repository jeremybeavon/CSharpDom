namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithSealedOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
