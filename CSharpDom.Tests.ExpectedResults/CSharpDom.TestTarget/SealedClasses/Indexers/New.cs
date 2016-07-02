namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithNewIndexer : BaseClassWithIndexer
    {
        public new string this[int index]
        {
            set { }
        }
    }
}
