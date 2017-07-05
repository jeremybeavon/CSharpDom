namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewVirtualIndexer
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
