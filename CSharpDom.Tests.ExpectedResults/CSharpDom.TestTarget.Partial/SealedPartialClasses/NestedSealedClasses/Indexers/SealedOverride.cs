namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithSealedOverrideIndexer
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
