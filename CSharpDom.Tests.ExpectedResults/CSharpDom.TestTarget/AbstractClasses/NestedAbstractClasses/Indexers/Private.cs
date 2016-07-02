namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithPrivateIndexer
    {
        public abstract class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
