namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithSealedOverrideIndexer
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
