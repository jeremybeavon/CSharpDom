namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers
{
    public static class StaticClassWithNestedSealedPartialClassWithSealedOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
