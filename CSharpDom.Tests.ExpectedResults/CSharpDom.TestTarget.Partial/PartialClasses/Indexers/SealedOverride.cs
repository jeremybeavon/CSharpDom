namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers
{
    public partial class PartialClassWithSealedOverrideIndexer : BaseClassWithIndexer
    {
        public sealed override string this[int index]
        {
            set { }
        }
    }
}
