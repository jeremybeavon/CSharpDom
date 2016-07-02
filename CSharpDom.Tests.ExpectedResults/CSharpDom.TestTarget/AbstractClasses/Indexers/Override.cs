namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithOverrideIndexer : BaseClassWithIndexer
    {
        public override string this[int index]
        {
            set { }
        }
    }
}
