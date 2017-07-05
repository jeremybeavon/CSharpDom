namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithSealedOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
