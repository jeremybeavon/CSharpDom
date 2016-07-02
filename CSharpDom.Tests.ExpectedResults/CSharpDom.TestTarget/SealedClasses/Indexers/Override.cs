namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithOverrideIndexer : BaseClassWithIndexer
    {
        public override string this[int index]
        {
            set { }
        }
    }
}
