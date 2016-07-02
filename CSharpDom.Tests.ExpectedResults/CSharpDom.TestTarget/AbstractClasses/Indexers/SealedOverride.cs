namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithSealedOverrideIndexer : BaseClassWithIndexer
    {
        public sealed override string this[int index]
        {
            set { }
        }
    }
}
