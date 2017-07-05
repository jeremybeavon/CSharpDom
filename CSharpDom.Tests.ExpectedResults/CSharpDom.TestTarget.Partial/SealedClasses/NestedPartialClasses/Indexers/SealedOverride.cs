namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedPartialClassWithSealedOverrideIndexer
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
