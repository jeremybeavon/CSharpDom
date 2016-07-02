namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithPrivateIndexer
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
