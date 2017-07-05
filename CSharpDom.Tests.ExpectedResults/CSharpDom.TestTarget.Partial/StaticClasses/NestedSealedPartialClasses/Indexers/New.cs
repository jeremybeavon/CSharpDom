namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers
{
    public static class StaticClassWithNestedSealedPartialClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
