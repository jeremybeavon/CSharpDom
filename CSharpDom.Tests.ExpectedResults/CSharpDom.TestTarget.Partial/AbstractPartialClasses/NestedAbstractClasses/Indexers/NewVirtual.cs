namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewVirtualIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new virtual string this[int index]
            {
                set { }
            }
        }
    }
}
