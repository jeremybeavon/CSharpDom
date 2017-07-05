namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewVirtualIndexer
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
