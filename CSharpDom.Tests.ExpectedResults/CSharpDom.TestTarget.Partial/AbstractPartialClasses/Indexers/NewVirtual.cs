namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNewVirtualIndexer : BaseClassWithIndexer
    {
        public new virtual string this[int index]
        {
            set { }
        }
    }
}
