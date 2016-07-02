namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithVirtualIndexer
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
