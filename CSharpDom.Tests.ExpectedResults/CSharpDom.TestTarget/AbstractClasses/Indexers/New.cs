namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithNewIndexer : BaseClassWithIndexer
    {
        public new string this[int index]
        {
            set { }
        }
    }
}
