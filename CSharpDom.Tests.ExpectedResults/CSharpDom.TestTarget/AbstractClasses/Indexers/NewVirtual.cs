namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithNewVirtualIndexer : BaseClassWithIndexer
    {
        public new virtual string this[int index]
        {
            set { }
        }
    }
}
