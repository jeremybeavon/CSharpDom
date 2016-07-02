namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithNewIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
