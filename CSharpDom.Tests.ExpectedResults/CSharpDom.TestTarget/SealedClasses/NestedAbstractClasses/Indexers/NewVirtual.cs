namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithNewVirtualIndexer
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
