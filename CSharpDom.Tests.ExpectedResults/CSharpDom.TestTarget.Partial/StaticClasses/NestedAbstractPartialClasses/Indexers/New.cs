namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithNewIndexer
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
