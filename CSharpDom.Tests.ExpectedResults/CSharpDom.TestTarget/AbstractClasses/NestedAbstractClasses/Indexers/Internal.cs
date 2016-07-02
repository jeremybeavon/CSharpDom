namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithInternalIndexer
    {
        public abstract class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
