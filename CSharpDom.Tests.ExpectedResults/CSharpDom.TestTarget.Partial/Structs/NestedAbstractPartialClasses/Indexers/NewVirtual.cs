namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers
{
    public struct StructWithNestedAbstractPartialClassWithNewVirtualIndexer
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
