namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithVirtualIndexer
    {
        public abstract class Class
        {
            public virtual string this[int index]
            {
                set { }
            }
        }
    }
}
