namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithSealedOverrideIndexer : BaseClassWithIndexer
    {
        public sealed override string this[int index]
        {
            set { }
        }
    }
}
