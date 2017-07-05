namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithNewVirtualIndexer
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
