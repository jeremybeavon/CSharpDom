namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers
{
    public static class StaticClassWithNestedPartialClassWithSealedOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
